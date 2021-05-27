using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForAmountPayable
{
    public partial class CalculatorForAmountPayable : Form
    {
        public static List<Product> products = new List<Product>();
        public CalculatorForAmountPayable()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();

            products.Add(new Product
            {
                Name = NameInput.Text,
                Price = Convert.ToDouble(PriceInput.Text)
            });

            foreach (var item in products)
            {
                productListBox.Items.Add(item.ShowNameAndPrice());
            }

        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            products.Clear();
        }
    }
}
