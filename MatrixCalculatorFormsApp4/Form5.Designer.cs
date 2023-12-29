namespace MatrixCalculatorFormsApp4
{
    partial class MsgBox2
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
            this.MsgLabel2 = new System.Windows.Forms.Label();
            this.MsgTextBox2 = new System.Windows.Forms.TextBox();
            this.MsgPictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrixATxtBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultTxtBox2 = new System.Windows.Forms.TextBox();
            this.SaveButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MsgPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgLabel2
            // 
            this.MsgLabel2.AutoSize = true;
            this.MsgLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLabel2.Location = new System.Drawing.Point(271, 9);
            this.MsgLabel2.Name = "MsgLabel2";
            this.MsgLabel2.Size = new System.Drawing.Size(120, 18);
            this.MsgLabel2.TabIndex = 7;
            this.MsgLabel2.Text = "Message Label 2";
            // 
            // MsgTextBox2
            // 
            this.MsgTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTextBox2.Location = new System.Drawing.Point(149, 39);
            this.MsgTextBox2.Multiline = true;
            this.MsgTextBox2.Name = "MsgTextBox2";
            this.MsgTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MsgTextBox2.Size = new System.Drawing.Size(398, 88);
            this.MsgTextBox2.TabIndex = 8;
            // 
            // MsgPictureBox2
            // 
            this.MsgPictureBox2.Location = new System.Drawing.Point(149, 143);
            this.MsgPictureBox2.Name = "MsgPictureBox2";
            this.MsgPictureBox2.Size = new System.Drawing.Size(398, 429);
            this.MsgPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MsgPictureBox2.TabIndex = 9;
            this.MsgPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input Matrix A :";
            // 
            // MatrixATxtBox2
            // 
            this.MatrixATxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatrixATxtBox2.Location = new System.Drawing.Point(163, 591);
            this.MatrixATxtBox2.Multiline = true;
            this.MatrixATxtBox2.Name = "MatrixATxtBox2";
            this.MatrixATxtBox2.Size = new System.Drawing.Size(100, 83);
            this.MatrixATxtBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Result :";
            // 
            // ResultTxtBox2
            // 
            this.ResultTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxtBox2.Location = new System.Drawing.Point(420, 591);
            this.ResultTxtBox2.Multiline = true;
            this.ResultTxtBox2.Name = "ResultTxtBox2";
            this.ResultTxtBox2.Size = new System.Drawing.Size(100, 83);
            this.ResultTxtBox2.TabIndex = 13;
            // 
            // SaveButton2
            // 
            this.SaveButton2.Location = new System.Drawing.Point(526, 621);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(57, 22);
            this.SaveButton2.TabIndex = 14;
            this.SaveButton2.Text = "Save";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // MsgBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 693);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.ResultTxtBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatrixATxtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgPictureBox2);
            this.Controls.Add(this.MsgTextBox2);
            this.Controls.Add(this.MsgLabel2);
            this.Name = "MsgBox2";
            this.Text = "Message Box 2";
            ((System.ComponentModel.ISupportInitialize)(this.MsgPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MsgLabel2;
        public System.Windows.Forms.TextBox MsgTextBox2;
        public System.Windows.Forms.PictureBox MsgPictureBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MatrixATxtBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox ResultTxtBox2;
        private System.Windows.Forms.Button SaveButton2;
    }
}