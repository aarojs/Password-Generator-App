namespace PasswordGenerator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudLength = new NumericUpDown();
            chkUppercase = new CheckBox();
            chkLowercase = new CheckBox();
            chkNumbers = new CheckBox();
            chkSymbols = new CheckBox();
            btnGenerate = new Button();
            txtResult = new TextBox();
            btnCopy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            SuspendLayout();
            // 
            // nudLength
            // 
            nudLength.Location = new Point(355, 110);
            nudLength.Name = "nudLength";
            nudLength.Size = new Size(180, 31);
            nudLength.TabIndex = 0;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.Location = new Point(166, 148);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(121, 29);
            chkUppercase.TabIndex = 1;
            chkUppercase.Text = "Uppercase";
            chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.Location = new Point(311, 148);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(119, 29);
            chkLowercase.TabIndex = 2;
            chkLowercase.Text = "Lowercase";
            chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Location = new Point(166, 192);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(111, 29);
            chkNumbers.TabIndex = 3;
            chkNumbers.Text = "Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.Location = new Point(311, 192);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(106, 29);
            chkSymbols.TabIndex = 4;
            chkSymbols.Text = "Symbols";
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(165, 242);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 34);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(165, 337);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(465, 31);
            txtResult.TabIndex = 6;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(518, 297);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(112, 34);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(165, 50);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 8;
            label1.Text = "Password Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 300);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 9;
            label2.Text = "Generated Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 112);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 10;
            label3.Text = "Number of characters";
            // 
            // PasswordGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCopy);
            Controls.Add(txtResult);
            Controls.Add(btnGenerate);
            Controls.Add(chkSymbols);
            Controls.Add(chkNumbers);
            Controls.Add(chkLowercase);
            Controls.Add(chkUppercase);
            Controls.Add(nudLength);
            Name = "PasswordGeneratorForm";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudLength;
        private CheckBox chkUppercase;
        private CheckBox chkLowercase;
        private CheckBox chkNumbers;
        private CheckBox chkSymbols;
        private Button btnGenerate;
        private TextBox txtResult;
        private Button btnCopy;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
