namespace _14
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
            comboBoxCategory = new ComboBox();
            listBoxProducts = new ListBox();
            buttonAddProduct = new Button();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(334, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 15;
            listBoxProducts.Location = new Point(5, 12);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(303, 214);
            listBoxProducts.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(12, 232);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(140, 23);
            buttonAddProduct.TabIndex = 2;
            buttonAddProduct.Text = "Додати новий продукт";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 263);
            Controls.Add(buttonAddProduct);
            Controls.Add(listBoxProducts);
            Controls.Add(comboBoxCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxCategory;
        private ListBox listBoxProducts;
        private Button buttonAddProduct;
    }
}
