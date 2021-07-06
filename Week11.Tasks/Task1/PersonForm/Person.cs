using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonForm.Form1;

namespace PersonForm
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }


        public void ShowNS(Person person, Label name, Label surname)
        {
            name.Text = person.Name;
            surname.Text = person.SurName;
        }

        public void ShowNSCo(Person person, Label name, Label surname, Label country)
        {
            name.Text = person.Name;
            surname.Text = person.SurName;
            country.Text = person.Country;
        }
        public void ShowNSCoCi(Person person, Label name, Label surname, Label country, Label city)
        {
            name.Text = person.Name;
            surname.Text = person.SurName;
            country.Text = person.Country;
            city.Text = person.City;
        }
        public void ShowNSCoCiB(Person person, Label name, Label surname, Label country, Label city, Label date)
        {
            name.Text = person.Name;
            surname.Text = person.SurName;
            country.Text = person.Country;
            city.Text = person.City;
            date.Text = person.BirthDate.ToString();

        }
    }
}
