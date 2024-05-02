namespace _14
{
    partial class Form2
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
            numericUpDownPrice = new NumericUpDown();
            textBoxCategory = new TextBox();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(132, 25);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 9;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(258, 25);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(100, 23);
            textBoxCategory.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(21, 25);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(376, 25);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(468, 25);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 71);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "Form2";
            Text = "Додавання нового продукту";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxCategory;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}