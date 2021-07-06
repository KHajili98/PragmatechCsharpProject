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
        List<string> formats = new()
        {
            "Name Surname",
            "Name Surname, Country",
            "Name Surname, Country, City",
            "Name Surname, Country, City, Birthdate",
        };

        public Form1()
        {

            InitializeComponent();

            listBoxFormat.Items.Add("Name Surname");
            listBoxFormat.Items.Add("Name Surname, Country");
            listBoxFormat.Items.Add("Name Surname, Country, City");
            listBoxFormat.Items.Add("Name Surname, Country, City, Birthdate");
        }

        Person newPerson = new();

        public  delegate void ShowHandler();

        private void showButton_Click(object sender, EventArgs e)
        {
            newPerson.Name = txtName.Text;
            newPerson.SurName = txtSurname.Text;
            newPerson.City = txtCity.Text;
            newPerson.Country = txtCountry.Text;
            newPerson.BirthDate = dateTimePicker.Value;
            // dateTimePicker.Value = newPerson.BirthDate;

            lblName.Text = null;
            lblSurname.Text = null;
            lblCountry.Text = null;
            lblCity.Text = null;
            lblBirthDay.Text = null;

            switch (listBoxFormat.SelectedIndex)
            {
                case 0: newPerson.ShowNS(newPerson, lblName, lblSurname); break;
                case 1: newPerson.ShowNSCo(newPerson, lblName, lblSurname, lblCountry); break;
                case 2:newPerson.ShowNSCoCi(newPerson, lblName, lblSurname, lblCountry, lblCity); break;
                case 3: newPerson.ShowNSCoCiB(newPerson, lblName, lblSurname, lblCountry, lblCity, lblBirthDay); break;
            }

        }
    }
}
