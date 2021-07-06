using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonForm
{
    public partial class Form1 : Form
    {
        Person newPerson = new();

        public Form1()
        {
           
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            txtName.Text = newPerson.Name;
            txtSurname.Text = newPerson.SurName;
            txtCity.Text = newPerson.City;
            txtCountry.Text = newPerson.Country;


        }
    }
}
