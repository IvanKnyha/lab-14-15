namespace _15
{
    partial class Form1
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            ageNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 13);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(120, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(12, 61);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(120, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 164);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(120, 23);
            emailTextBox.TabIndex = 2;
            // 
            // ageNumericUpDown
            // 
            ageNumericUpDown.Location = new Point(12, 107);
            ageNumericUpDown.Name = "ageNumericUpDown";
            ageNumericUpDown.Size = new Size(120, 23);
            ageNumericUpDown.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(152, 198);
            Controls.Add(ageNumericUpDown);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "Form1";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)ageNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private NumericUpDown ageNumericUpDown;
    }
}
