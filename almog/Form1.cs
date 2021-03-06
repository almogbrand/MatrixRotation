﻿/*
 * Hello :)
 * This simple app allowes a user to build a dynamic NxN matrix.
 * Add random values to it, and rotate the matrix. 
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace almog
{
    public partial class Form1 : Form
    {
        //TODO
        // Add support for MxN matrix. as M!=N
        // (1) update Tranpose 
        // (2) cancele rows == cols check when building a new matrix 

        // Change these in order to define matrix (x,y) starting point and spaces between cells
        public const int X_START = 10;
        public const int Y_START = 10;
        public const int X_SPACER = 40;
        public const int Y_SPACER = 40;
        public const int WIDTH = 25;
        public const int HEIGHT = 25;
        public bool transposeFlage = false;
        public int rows = 0, cols = 0;
        public Form1()
        {
            InitializeComponent();

            txtRotate.Enabled = false;
            lblRotateMatrix.ForeColor = Color.FromArgb(211, 211, 211);
            lblRotateMatrix2.ForeColor = Color.FromArgb(211, 211, 211);
            btnRotate.Enabled = false;

            lblFill1.ForeColor = Color.FromArgb(211, 211, 211);
            lblFill2.ForeColor = Color.FromArgb(211, 211, 211);
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
            btnFill.Enabled = false;

            lblreflect.ForeColor = Color.FromArgb(211, 211, 211);
            btnReflectRightLeft.Enabled = false;
            btnReflectUpDown.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //making sure user cannot input a none numeric char to a textbox
            txtCols.KeyPress += Txt_KeyPress_Check;
            txtRows.KeyPress += Txt_KeyPress_Check;
            txtFrom.KeyPress += Txt_KeyPress_Check;
            txtTo.KeyPress += Txt_KeyPress_Check;
            txtRotate.KeyPress += Txt_KeyPress_Check;
        }

        ///////////////////////
        //  Build   matrix   //
        ///////////////////////

        private void Txt_KeyPress_Check(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '-');
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(txtRows.Text)) <= 0 || Convert.ToInt32(txtCols.Text) <= 0)
            {
                MessageBox.Show("Invalid matrix size. rows & cols number should be higher than 1");
            }
            else if ((Convert.ToInt32(txtRows.Text)) != Convert.ToInt32(txtCols.Text))
            {
                MessageBox.Show("Currently supporting only a NxN matrix");
            }
            else
            {

                txtRotate.Enabled = true;
                btnRotate.Enabled = true;
                lblRotateMatrix.ForeColor = Color.FromArgb(0, 0, 0);
                lblRotateMatrix2.ForeColor = Color.FromArgb(0, 0, 0);

                lblFill1.ForeColor = Color.FromArgb(0, 0, 0);
                lblFill2.ForeColor = Color.FromArgb(0, 0, 0);
                txtFrom.Enabled = true;
                txtTo.Enabled = true;
                btnFill.Enabled = true;

                lblreflect.ForeColor = Color.FromArgb(0, 0, 0);
                btnReflectRightLeft.Enabled = true;
                btnReflectUpDown.Enabled = true;

                panel2.Controls.Clear();
                rows = Convert.ToInt32(txtRows.Text);
                cols = Convert.ToInt32(txtCols.Text);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        var tb = new TextBox()
                        {
                            Name = $"{col}-{row}",
                            Width = WIDTH,
                            Text = "0",
                            Location = new Point(col * (WIDTH + 2) + 10, row * (HEIGHT + 2))
                        };
                        tb.KeyPress += Txt_KeyPress_Check;
                        panel2.Controls.Add(tb);
                    }
                }
                return;
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtFrom.Text)) > int.Parse(txtTo.Text))
            {
                MessageBox.Show("Invalid range. Start index should be lower to End index.");
            }
            else
            {
                Random r = new Random();
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        var ctrl = (TextBox)panel2.Controls[$"{col}-{row}"];
                        ctrl.Text = r.Next(int.Parse(txtFrom.Text), int.Parse(txtTo.Text)).ToString();
                    }
                }
            }
        }

        ///////////////////////
        //  Rotate  matrix   //
        ///////////////////////

        private void btnRotate_Click(object sender, EventArgs e)
        {
            var rot = float.Parse(txtRotate.Text);

            // spin feature - allowes user to watch the matrix spin with jumps of 12.5 degrees
            if (rot == 0)
            {
                this.UseWaitCursor = true;
                while (true)
                {
                    for (float i = 0; i < 360; i += 12.5f)
                    {
                        RotateMatrix(i);
                        Application.DoEvents();
                        //Thread.Sleep(100);
                        if ((ModifierKeys & Keys.Control) == Keys.Control)
                        {
                            break;
                        }
                    }
                    if ((ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        break;
                    }
                }
                this.UseWaitCursor = false;
            }

            // normal rotation
            else
                RotateMatrix(rot);
        }

        private void RotateMatrix(float angle)
        {
            var pivot = new PointF((cols - 1) * 100 / 2, (rows - 1) * 100 / 2);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var srcCtrl = (TextBox)panel2.Controls[$"{col}-{row}"];
                    var srcXY = new PointF(col * 100, row * 100);
                    var dstXY = RotateAround(srcXY, pivot, angle);
                    var dstCtrl = (TextBox)panel2.Controls[$"{ Math.Round(dstXY.X / 100)}-{Math.Round(dstXY.Y / 100)}"];
                    if (dstCtrl == null)
                        srcCtrl.Text = "";
                    else if (dstCtrl.Tag == null)
                        dstCtrl.Tag = srcCtrl.Text;
                }
            }
            foreach (TextBox tb in panel2.Controls)
            {
                if (tb.Tag != null)
                    tb.Text = tb.Tag.ToString();
                if (tb.Text == "0") tb.Text = "";
                tb.Tag = null;
            }
        }

        public PointF RotateAround(PointF point, PointF pivot, double angleDegree)
        {
            double angle = angleDegree * Math.PI / 180;
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            double dx = point.X - pivot.X;
            double dy = point.Y - pivot.Y;
            double x = cos * dx - sin * dy + pivot.X;
            double y = sin * dx + cos * dy + pivot.Y;
            return new PointF((float)x, (float)y);
        }

        ///////////////////////
        //  Reflect  matrix  //
        ///////////////////////

        private void btnReflectUp_Click(object sender, EventArgs e)
        {
            reversCol();
        }

        private void btnReflectRightLeft_Click(object sender, EventArgs e)
        {
            reversRow();
        }

        public void reversCol()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    //temp <- end
                    String temp = panel2.Controls[$"{i}-{cols - j - 1}"].Text.ToString();

                    //end <- start
                    panel2.Controls[$"{i}-{cols - j - 1}"].Text = panel2.Controls[$"{i}-{j}"].Text;

                    //start <- temp
                    panel2.Controls[$"{i}-{j}"].Text = temp;
                }
            }
        }

        public void reversRow()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    //temp <- end
                    String temp = panel2.Controls[$"{cols - j - 1}-{i}"].Text.ToString();

                    //end <- start
                    panel2.Controls[$"{cols - j - 1}-{i}"].Text = panel2.Controls[$"{j}-{i}"].Text;

                    //start <- temp
                    panel2.Controls[$"{j}-{i}"].Text = temp;
                }
            }
        }

        public void transportMatrix()
        {

            string[,] arr = new string[rows, cols];

            //fill arr with current matrix values 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = panel2.Controls[$"{i}-{j}"].Text.ToString();
                }
            }

            //update matrix with transposed values 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    panel2.Controls[$"{j}-{i}"].Text = arr[i, j];
                }
            }
        }

    }
}
