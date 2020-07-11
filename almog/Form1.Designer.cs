namespace almog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCols = new System.Windows.Forms.TextBox();
            this.EnterMatrixSizeLable = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.empty = new System.Windows.Forms.Label();
            this.txtRotate = new System.Windows.Forms.TextBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.lblRotateMatrix = new System.Windows.Forms.Label();
            this.lblRotateMatrix2 = new System.Windows.Forms.Label();
            this.lblFill2 = new System.Windows.Forms.Label();
            this.lblFill1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblreflect = new System.Windows.Forms.Label();
            this.btnReflectRightLeft = new System.Windows.Forms.Button();
            this.btnReflectUpDown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(203, 4);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(35, 20);
            this.txtCols.TabIndex = 1;
            this.txtCols.Text = "0";
            // 
            // EnterMatrixSizeLable
            // 
            this.EnterMatrixSizeLable.AutoSize = true;
            this.EnterMatrixSizeLable.Location = new System.Drawing.Point(16, 7);
            this.EnterMatrixSizeLable.Name = "EnterMatrixSizeLable";
            this.EnterMatrixSizeLable.Size = new System.Drawing.Size(139, 13);
            this.EnterMatrixSizeLable.TabIndex = 2;
            this.EnterMatrixSizeLable.Text = "Enter matrix size (rows, cols)";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(246, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Matrix";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // empty
            // 
            this.empty.AutoSize = true;
            this.empty.Location = new System.Drawing.Point(28, 44);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(0, 13);
            this.empty.TabIndex = 4;
            // 
            // txtRotate
            // 
            this.txtRotate.Location = new System.Drawing.Point(534, 40);
            this.txtRotate.Name = "txtRotate";
            this.txtRotate.Size = new System.Drawing.Size(36, 20);
            this.txtRotate.TabIndex = 8;
            this.txtRotate.Text = "90";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(747, 39);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 9;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // lblRotateMatrix
            // 
            this.lblRotateMatrix.AutoSize = true;
            this.lblRotateMatrix.Location = new System.Drawing.Point(451, 43);
            this.lblRotateMatrix.Name = "lblRotateMatrix";
            this.lblRotateMatrix.Size = new System.Drawing.Size(83, 13);
            this.lblRotateMatrix.TabIndex = 8;
            this.lblRotateMatrix.Text = "Rotate matrix by";
            // 
            // lblRotateMatrix2
            // 
            this.lblRotateMatrix2.AutoSize = true;
            this.lblRotateMatrix2.Location = new System.Drawing.Point(571, 43);
            this.lblRotateMatrix2.Name = "lblRotateMatrix2";
            this.lblRotateMatrix2.Size = new System.Drawing.Size(175, 13);
            this.lblRotateMatrix2.TabIndex = 9;
            this.lblRotateMatrix2.Text = "degrees. (0 for SPIN, CTRL to stop)";
            // 
            // lblFill2
            // 
            this.lblFill2.AutoSize = true;
            this.lblFill2.Location = new System.Drawing.Point(648, 10);
            this.lblFill2.Name = "lblFill2";
            this.lblFill2.Size = new System.Drawing.Size(16, 13);
            this.lblFill2.TabIndex = 13;
            this.lblFill2.Text = "to";
            // 
            // lblFill1
            // 
            this.lblFill1.AutoSize = true;
            this.lblFill1.Location = new System.Drawing.Point(451, 10);
            this.lblFill1.Name = "lblFill1";
            this.lblFill1.Size = new System.Drawing.Size(159, 13);
            this.lblFill1.TabIndex = 12;
            this.lblFill1.Text = "Auto fill matrix with numbers from";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(747, 6);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(665, 7);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(36, 20);
            this.txtTo.TabIndex = 4;
            this.txtTo.Text = "0";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(609, 7);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(36, 20);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.Text = "0";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(162, 4);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(35, 20);
            this.txtRows.TabIndex = 0;
            this.txtRows.Text = "0";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblreflect);
            this.panel1.Controls.Add(this.btnReflectRightLeft);
            this.panel1.Controls.Add(this.btnReflectUpDown);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.lblFill2);
            this.panel1.Controls.Add(this.txtCols);
            this.panel1.Controls.Add(this.lblFill1);
            this.panel1.Controls.Add(this.EnterMatrixSizeLable);
            this.panel1.Controls.Add(this.btnFill);
            this.panel1.Controls.Add(this.txtRotate);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Controls.Add(this.lblRotateMatrix2);
            this.panel1.Controls.Add(this.lblRotateMatrix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 65);
            this.panel1.TabIndex = 14;
            // 
            // lblreflect
            // 
            this.lblreflect.AutoSize = true;
            this.lblreflect.Location = new System.Drawing.Point(16, 39);
            this.lblreflect.Name = "lblreflect";
            this.lblreflect.Size = new System.Drawing.Size(72, 13);
            this.lblreflect.TabIndex = 18;
            this.lblreflect.Text = "Reflect Matrix";
            // 
            // btnReflectRightLeft
            // 
            this.btnReflectRightLeft.Location = new System.Drawing.Point(170, 34);
            this.btnReflectRightLeft.Name = "btnReflectRightLeft";
            this.btnReflectRightLeft.Size = new System.Drawing.Size(75, 23);
            this.btnReflectRightLeft.TabIndex = 7;
            this.btnReflectRightLeft.Text = "Right/Left";
            this.btnReflectRightLeft.UseVisualStyleBackColor = true;
            this.btnReflectRightLeft.Click += new System.EventHandler(this.btnReflectRightLeft_Click);
            // 
            // btnReflectUpDown
            // 
            this.btnReflectUpDown.Location = new System.Drawing.Point(88, 34);
            this.btnReflectUpDown.Name = "btnReflectUpDown";
            this.btnReflectUpDown.Size = new System.Drawing.Size(75, 23);
            this.btnReflectUpDown.TabIndex = 6;
            this.btnReflectUpDown.Text = "Up/Down";
            this.btnReflectUpDown.UseVisualStyleBackColor = true;
            this.btnReflectUpDown.Click += new System.EventHandler(this.btnReflectUp_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 546);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(830, 600);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empty);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Text = "Matrix Rotate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label EnterMatrixSizeLable;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label empty;
        private System.Windows.Forms.TextBox txtRotate;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Label lblRotateMatrix;
        private System.Windows.Forms.Label lblRotateMatrix2;
        private System.Windows.Forms.Label lblFill2;
        private System.Windows.Forms.Label lblFill1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReflectUpDown;
        private System.Windows.Forms.Label lblreflect;
        private System.Windows.Forms.Button btnReflectRightLeft;
    }
}

