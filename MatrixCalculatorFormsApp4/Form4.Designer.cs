namespace MatrixCalculatorFormsApp4
{
    partial class MsgBox1
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
            this.MsgLabel1 = new System.Windows.Forms.Label();
            this.MsgTextBox1 = new System.Windows.Forms.TextBox();
            this.MsgPictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrixATxtBox1 = new System.Windows.Forms.TextBox();
            this.ResultTxtBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MsgPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgLabel1
            // 
            this.MsgLabel1.AutoSize = true;
            this.MsgLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLabel1.Location = new System.Drawing.Point(217, 31);
            this.MsgLabel1.Name = "MsgLabel1";
            this.MsgLabel1.Size = new System.Drawing.Size(120, 18);
            this.MsgLabel1.TabIndex = 0;
            this.MsgLabel1.Text = "Message Label 1";
            // 
            // MsgTextBox1
            // 
            this.MsgTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgTextBox1.Location = new System.Drawing.Point(122, 69);
            this.MsgTextBox1.Multiline = true;
            this.MsgTextBox1.Name = "MsgTextBox1";
            this.MsgTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MsgTextBox1.Size = new System.Drawing.Size(316, 84);
            this.MsgTextBox1.TabIndex = 1;
            // 
            // MsgPictureBox1
            // 
            this.MsgPictureBox1.Location = new System.Drawing.Point(122, 190);
            this.MsgPictureBox1.Name = "MsgPictureBox1";
            this.MsgPictureBox1.Size = new System.Drawing.Size(316, 163);
            this.MsgPictureBox1.TabIndex = 2;
            this.MsgPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Matrix A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MatrixATxtBox1
            // 
            this.MatrixATxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatrixATxtBox1.Location = new System.Drawing.Point(115, 405);
            this.MatrixATxtBox1.Multiline = true;
            this.MatrixATxtBox1.Name = "MatrixATxtBox1";
            this.MatrixATxtBox1.Size = new System.Drawing.Size(100, 83);
            this.MatrixATxtBox1.TabIndex = 4;
            // 
            // ResultTxtBox1
            // 
            this.ResultTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxtBox1.Location = new System.Drawing.Point(317, 405);
            this.ResultTxtBox1.Multiline = true;
            this.ResultTxtBox1.Name = "ResultTxtBox1";
            this.ResultTxtBox1.Size = new System.Drawing.Size(100, 83);
            this.ResultTxtBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Savebutton1
            // 
            this.Savebutton1.Location = new System.Drawing.Point(423, 438);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(62, 22);
            this.Savebutton1.TabIndex = 7;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MsgBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Savebutton1);
            this.Controls.Add(this.ResultTxtBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatrixATxtBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgPictureBox1);
            this.Controls.Add(this.MsgTextBox1);
            this.Controls.Add(this.MsgLabel1);
            this.Name = "MsgBox1";
            this.Text = "Message Box1";
            ((System.ComponentModel.ISupportInitialize)(this.MsgPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MsgLabel1;
        public System.Windows.Forms.TextBox MsgTextBox1;
        public System.Windows.Forms.PictureBox MsgPictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MatrixATxtBox1;
        public System.Windows.Forms.TextBox ResultTxtBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Savebutton1;
        private System.Windows.Forms.Button button2;
    }
}