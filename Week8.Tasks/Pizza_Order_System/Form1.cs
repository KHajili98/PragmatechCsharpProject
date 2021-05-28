using Pizza_Order_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_System
{
    public partial class Form1 : Form
    {
        public OrderedBy orderedBy = new OrderedBy();
        public List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza{Name="Mozorella",Small=5,Medium=10, Large=15},
            new Pizza{Name="Chicken",Small=10,Medium=15, Large=20},
            new Pizza{Name="Mixed",Small=15,Medium=20, Large=25},
        };
        public List<string> additions = new List<string>();
     

        public Form1()
        {
            InitializeComponent();

        }



        private void groupBoxSifariwci_Enter(object sender, EventArgs e)
        {
            groupBoxPizza.Enabled = false;
            groupBoxSoftDrinks.Enabled = false;
            OrderBtn.Enabled = false;
            ClearBtn.Enabled = false;
            DeleteOrdersBtn.Enabled = false;
            AddDrink.Enabled = false;
            AddPizza.Enabled = false;

        }
        private void BeginBtn_Click(object sender, EventArgs e)
        {
            orderedBy.Name = NameInput.Text;
            orderedBy.Adress = AddressInput.Text;
            orderedBy.Phone = PhoneInput.Text;
            orderedBy.Surname = SurnameInput.Text;

            groupBoxSifariwci.Enabled = false;
            groupBoxPizza.Enabled = true;
            groupBoxSoftDrinks.Enabled = true;
            OrderBtn.Enabled = true;
            ClearBtn.Enabled = true;
            DeleteOrdersBtn.Enabled = true;
            AddDrink.Enabled = true;
            AddPizza.Enabled = true;

            PizzaNameCombo.SelectedItem = null;
            PizzaNameCombo.SelectedText = "-----Select Pizza-----";

            SizePizzaCombo.SelectedItem = null;
            SizePizzaCombo.SelectedText = "-----Select Size-----";
            foreach (var pizza in pizzas)
            {
                PizzaNameCombo.Items.Add(pizza.Name);
            }
            List<string> sizes = new List<string>() { "Small", "Medium", "Large" };
            foreach (var item in sizes)
            {
                SizePizzaCombo.Items.Add(item);
            }
        }

        
    }
}
