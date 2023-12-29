namespace MatrixCalculatorFormsApp4
{
    partial class MatrixCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixCalculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DetButton = new System.Windows.Forms.RadioButton();
            this.TransposeButton = new System.Windows.Forms.RadioButton();
            this.CofactorButton = new System.Windows.Forms.RadioButton();
            this.AdjButton = new System.Windows.Forms.RadioButton();
            this.InverseButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.RadioButton();
            this.SubtractButton = new System.Windows.Forms.RadioButton();
            this.MultiplyButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InputMatrixAtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMatrixBtextBox = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMemory2 = new System.Windows.Forms.ListBox();
            this.PasteMemoryA = new System.Windows.Forms.Button();
            this.PasteMemoryB = new System.Windows.Forms.Button();
            this.lstMemory1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select one of the operation to perform";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DetButton
            // 
            this.DetButton.AutoSize = true;
            this.DetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetButton.Location = new System.Drawing.Point(40, 76);
            this.DetButton.Name = "DetButton";
            this.DetButton.Size = new System.Drawing.Size(106, 22);
            this.DetButton.TabIndex = 1;
            this.DetButton.TabStop = true;
            this.DetButton.Text = "Determinant";
            this.DetButton.UseVisualStyleBackColor = true;
            this.DetButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TransposeButton
            // 
            this.TransposeButton.AutoSize = true;
            this.TransposeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransposeButton.Location = new System.Drawing.Point(174, 76);
            this.TransposeButton.Name = "TransposeButton";
            this.TransposeButton.Size = new System.Drawing.Size(97, 22);
            this.TransposeButton.TabIndex = 2;
            this.TransposeButton.TabStop = true;
            this.TransposeButton.Text = "Transpose";
            this.TransposeButton.UseVisualStyleBackColor = true;
            this.TransposeButton.CheckedChanged += new System.EventHandler(this.TransposeButton_CheckedChanged);
            // 
            // CofactorButton
            // 
            this.CofactorButton.AutoSize = true;
            this.CofactorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CofactorButton.Location = new System.Drawing.Point(296, 76);
            this.CofactorButton.Name = "CofactorButton";
            this.CofactorButton.Size = new System.Drawing.Size(84, 22);
            this.CofactorButton.TabIndex = 3;
            this.CofactorButton.TabStop = true;
            this.CofactorButton.Text = "Cofactor";
            this.CofactorButton.UseVisualStyleBackColor = true;
            // 
            // AdjButton
            // 
            this.AdjButton.AutoSize = true;
            this.AdjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjButton.Location = new System.Drawing.Point(406, 76);
            this.AdjButton.Name = "AdjButton";
            this.AdjButton.Size = new System.Drawing.Size(82, 22);
            this.AdjButton.TabIndex = 4;
            this.AdjButton.TabStop = true;
            this.AdjButton.Text = "Adjugate";
            this.AdjButton.UseVisualStyleBackColor = true;
            this.AdjButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // InverseButton
            // 
            this.InverseButton.AutoSize = true;
            this.InverseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InverseButton.Location = new System.Drawing.Point(40, 131);
            this.InverseButton.Name = "InverseButton";
            this.InverseButton.Size = new System.Drawing.Size(73, 22);
            this.InverseButton.TabIndex = 5;
            this.InverseButton.TabStop = true;
            this.InverseButton.Text = "Inverse";
            this.InverseButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(174, 131);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(51, 22);
            this.AddButton.TabIndex = 6;
            this.AddButton.TabStop = true;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // SubtractButton
            // 
            this.SubtractButton.AutoSize = true;
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(296, 131);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(81, 22);
            this.SubtractButton.TabIndex = 7;
            this.SubtractButton.TabStop = true;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.AutoSize = true;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyButton.Location = new System.Drawing.Point(406, 131);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 22);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.TabStop = true;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_3);
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(174, 410);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(206, 31);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Do The Calculation";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input Matrix B :";
            // 
            // InputMatrixAtextBox
            // 
            this.InputMatrixAtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMatrixAtextBox.Location = new System.Drawing.Point(94, 318);
            this.InputMatrixAtextBox.Multiline = true;
            this.InputMatrixAtextBox.Name = "InputMatrixAtextBox";
            this.InputMatrixAtextBox.Size = new System.Drawing.Size(101, 69);
            this.InputMatrixAtextBox.TabIndex = 11;
            this.InputMatrixAtextBox.Text = "2 0 2\r\n0 1 0\r\n1 0 3\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Matrix A :";
            // 
            // InputMatrixBtextBox
            // 
            this.InputMatrixBtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputMatrixBtextBox.Location = new System.Drawing.Point(320, 318);
            this.InputMatrixBtextBox.Multiline = true;
            this.InputMatrixBtextBox.Name = "InputMatrixBtextBox";
            this.InputMatrixBtextBox.Size = new System.Drawing.Size(101, 69);
            this.InputMatrixBtextBox.TabIndex = 15;
            this.InputMatrixBtextBox.Text = "1 2\r\n3 4\r\n5 6\r\n";
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(526, 616);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 16;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 77);
            this.label4.TabIndex = 14;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Save The Result Matrix Of The Operation:\r\n\r\n";
            // 
            // lstMemory2
            // 
            this.lstMemory2.FormattingEnabled = true;
            this.lstMemory2.Location = new System.Drawing.Point(177, 499);
            this.lstMemory2.Name = "lstMemory2";
            this.lstMemory2.Size = new System.Drawing.Size(294, 108);
            this.lstMemory2.TabIndex = 18;
            this.lstMemory2.SelectedIndexChanged += new System.EventHandler(this.lstMemory2_SelectedIndexChanged);
            // 
            // PasteMemoryA
            // 
            this.PasteMemoryA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteMemoryA.Location = new System.Drawing.Point(201, 330);
            this.PasteMemoryA.Name = "PasteMemoryA";
            this.PasteMemoryA.Size = new System.Drawing.Size(86, 48);
            this.PasteMemoryA.TabIndex = 20;
            this.PasteMemoryA.Text = "Paste from memory to A";
            this.PasteMemoryA.UseVisualStyleBackColor = true;
            this.PasteMemoryA.Click += new System.EventHandler(this.PasteMemoryA_Click);
            // 
            // PasteMemoryB
            // 
            this.PasteMemoryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteMemoryB.Location = new System.Drawing.Point(427, 330);
            this.PasteMemoryB.Name = "PasteMemoryB";
            this.PasteMemoryB.Size = new System.Drawing.Size(85, 48);
            this.PasteMemoryB.TabIndex = 21;
            this.PasteMemoryB.Text = "Paste from memory to B\r\n";
            this.PasteMemoryB.UseVisualStyleBackColor = true;
            this.PasteMemoryB.Click += new System.EventHandler(this.PasteMemoryB_Click);
            // 
            // lstMemory1
            // 
            this.lstMemory1.FormattingEnabled = true;
            this.lstMemory1.Location = new System.Drawing.Point(72, 499);
            this.lstMemory1.Name = "lstMemory1";
            this.lstMemory1.Size = new System.Drawing.Size(87, 108);
            this.lstMemory1.TabIndex = 19;
            // 
            // MatrixCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 651);
            this.Controls.Add(this.PasteMemoryB);
            this.Controls.Add(this.PasteMemoryA);
            this.Controls.Add(this.lstMemory1);
            this.Controls.Add(this.lstMemory2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.InputMatrixBtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputMatrixAtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InverseButton);
            this.Controls.Add(this.AdjButton);
            this.Controls.Add(this.CofactorButton);
            this.Controls.Add(this.TransposeButton);
            this.Controls.Add(this.DetButton);
            this.Controls.Add(this.label1);
            this.Name = "MatrixCalculatorForm";
            this.Text = "MatrixCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DetButton;
        private System.Windows.Forms.RadioButton TransposeButton;
        private System.Windows.Forms.RadioButton CofactorButton;
        private System.Windows.Forms.RadioButton AdjButton;
        private System.Windows.Forms.RadioButton InverseButton;
        private System.Windows.Forms.RadioButton AddButton;
        private System.Windows.Forms.RadioButton SubtractButton;
        private System.Windows.Forms.RadioButton MultiplyButton;
        private System.Windows.Forms.Button CalculateButton;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox InputMatrixAtextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox InputMatrixBtextBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMemory2;
        private System.Windows.Forms.Button PasteMemoryA;
        private System.Windows.Forms.Button PasteMemoryB;
        private System.Windows.Forms.ListBox lstMemory1;
    }
}

