using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




/*
````````2. Person classi yaratmalisiz 
````````id, 
````````name, 
````````surname, 
````````birthdate, 
````````country , 
````````city, 
````````phone, 
````````email,
````````profession, Dizayn elediyiniz formApp de FakeData istifade ederek en az 1000 eded data yaradilib dataGride yerlesdirilecek (orderBY(profession)),
````````dataGrid-in ust hissesinde olan searchTXTBox dan daxil edilen deyere gore ilk 3 herf daxil edildikden sonra cedvelde deyere sahib
````````data gosterilmeli yoxdursa bu haqqda melumat verilmelidir , hemcinin cedvelin ustunde olan listBoxdan name, profession, Country deyerlerinden biri secilerse ona gore siralama olacaq


 * */


namespace PersonInfoSortedVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            listBox1.Items.Add("Name");
            listBox1.Items.Add("Profession");
            listBox1.Items.Add("Country");
        }

        FakeMemory memory = new FakeMemory();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FakeMemory.FetchPeople().OrderBy(p=>p.Profession).ToList();
            dataGridView1.Columns["Id"].Visible = false;
            
        }

        private void orderByButton_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = FakeMemory.FetchPeople().OrderBy(p => p.Name).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = FakeMemory.FetchPeople().OrderBy(p => p.Profession).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = FakeMemory.FetchPeople().OrderBy(p => p.Country).ToList();
                    break;
            }
        }
    }
}
