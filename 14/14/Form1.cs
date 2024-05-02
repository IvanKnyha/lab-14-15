using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            InitializeProducts();
            PopulateComboBox();
            PopulateListBox();
        }


        private void InitializeProducts()
        {
            products.Add(new Product("�������", 10.99m, "�����������"));
            products.Add(new Product("���", 20.49m, "������"));
            products.Add(new Product("���", 15.99m, "������"));
            products.Add(new Product("�������", 1.99m, "������"));
            products.Add(new Product("�'���", 19.99m, "�����������"));
            products.Add(new Product("������", 2.99m, "������"));
        }

        private void PopulateComboBox()
        {
            foreach (var product in products)
            {
                if (!comboBoxCategory.Items.Contains(product.Category))
                {
                    comboBoxCategory.Items.Add(product.Category);
                }
            }
        }

        private void PopulateListBox()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                listBoxProducts.Items.Add(product);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.SelectedItem as string;
            if (selectedCategory != null)
            {
                listBoxProducts.Items.Clear();
                foreach (var product in products)
                {
                    if (product.Category == selectedCategory)
                    {
                        listBoxProducts.Items.Add(product);
                    }
                }
            }
            else
            {
                PopulateListBox();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Form2 addProductForm = new Form2();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                products.Add(addProductForm.NewProduct);
                PopulateComboBox();
                PopulateListBox();
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    



    }
}
