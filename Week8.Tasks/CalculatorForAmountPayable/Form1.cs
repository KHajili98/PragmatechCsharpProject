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
        double cash;

        public CalculatorForAmountPayable()
        {
            InitializeComponent();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            double result;
            string _name;

            if (!Double.TryParse(PriceInput.Text,  out result) || string.IsNullOrEmpty(NameInput.Text))
            {
                MessageBox.Show($"Price or Name is not valid !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = Convert.ToDouble(PriceInput.Text);
                _name = NameInput.Text;
                products.Add(new Product
                {
                    Name = _name,
                    Price = result
                });
            }

            foreach (var item in products)
            {
                productListBox.Items.Add(item.ShowNameAndPrice());
            }

        }

       

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            foreach (var item in products)
            {
                cash += item.Price;
            }
            cash += cash * 0.18;// butun mallarda edv olduguna gore sonda bura elave etdim....

            if (studentCard.Checked)
            {
                cash -= cash * 0.2;//telebekartina gore 20% endirim eledim...
            }

            if (pensionable.Checked)
            {
                cash -= cash * 0.3;//telebekartina gore 30% endirim eledim...
            }

            CashLabel.Text = cash.ToString("0.##") +" ( +18 % EDV Daxil )";
            cash = 0;
        }
        private void ClearList_Click(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            products.Clear();
            CashLabel.Text = "0.00";
        }
    }
}
