using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form2 : Form
    {
        public Product NewProduct { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = numericUpDownPrice.Value;
            string category = textBoxCategory.Text;

            NewProduct = new Product(name, price, category);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }  
}
