using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNewCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        

        public void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text) || string.IsNullOrEmpty(surnameInput.Text))
            {
                MessageBox.Show($"Please enter name and surname !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                customers.Add(new Customer()
                {
                    Name = nameInput.Text,
                    Surname = surnameInput.Text,
                    Email = emailInput.Text,
                    Phone = phoneInput.Text
                });


                string message = "Do you want to add new customer again?";
                string title = "Add New Customer";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Count of Customers is {customers.Count}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameInput.Clear();
                    surnameInput.Clear();
                    emailInput.Clear();
                    phoneInput.Clear();
                }
                else
                {
                    nameInput.Clear();
                    surnameInput.Clear();
                    emailInput.Clear();
                    phoneInput.Clear();
                }
                listBox1.Items.Clear();

                foreach (var item in customers)
                {
                    var listboxItem = item.Name + " " + item.Surname;
                    listBox1.Items.Add(listboxItem);
                }

            }


        }
    }
}
