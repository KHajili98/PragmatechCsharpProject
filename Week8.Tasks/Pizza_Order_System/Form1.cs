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
        public decimal cashForPizza;
        public string pizzaOrderForList;
        public OrderedBy orderedBy = new OrderedBy();
        public List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza{Name="Mozorella",Small=5,Medium=10, Large=15},
            new Pizza{Name="Chicken",Small=10,Medium=15, Large=20},
            new Pizza{Name="Mixed",Small=15,Medium=20, Large=25},
        };
        public List<string> additions = new List<string>();



        public List<SoftDrink> drinks = new List<SoftDrink>()
        {
            new SoftDrink{Name = "Fanta", Price=1},
            new SoftDrink{Name = "Cola", Price=2},
            new SoftDrink{Name = "Redbull", Price=5},
            new SoftDrink{Name = "Vitamin", Price=3},
        };
        public string drinkOrderForList;
        public decimal cashForDrink;

        public decimal totalAmount;
        

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

            #region pizza combo duzeliwi

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

            #endregion



            #region drink ucun combo duzeliwi

            DrinkCombo.SelectedItem = null;
            DrinkCombo.SelectedText = "-----Select Drink-----";

            foreach (var drink in drinks)
            {
                DrinkCombo.Items.Add(drink.Name);
            }

            #endregion
        }

        private void AddPizza_Click(object sender, EventArgs e)
        {

            if (PizzaNameCombo.SelectedItem != null && SizePizzaCombo.SelectedItem!=null && numericPiiza.Value!=0)
            {
                decimal onePrice=0;
                decimal count;
                string icindekiler = "";

                Pizza selectedPizza = new Pizza
                {
                    Name = PizzaNameCombo.SelectedItem.ToString(),

                };

                for (int i = 0; i < pizzas.Count; i++) // loop secdiyimiz pizzaya uygun birinin qiymetini teyin etmek ucundur...
                {
                    Pizza temp = pizzas[i];
                    if (selectedPizza.Name == temp.Name)
                    {
                        switch (SizePizzaCombo.SelectedItem.ToString())
                        {
                            case "Small":
                                onePrice = temp.Small;
                                break;
                            case "Medium":
                                onePrice = temp.Medium;
                                break;
                            case "Large":
                                onePrice = temp.Large;
                                break;
                        }
                        break;
                    }
                }

                count = numericPiiza.Value; // ne qeder secdiyi...
                cashForPizza = count * onePrice; // bir pizza sifariw verende toplam qiymet...


                if (checkBoxPomidor.Checked)
                    additions.Add(checkBoxPomidor.Text);
                if (checkBoxGobelek.Checked)
                    additions.Add(checkBoxGobelek.Text);
                if (checkBoxSous.Checked)
                    additions.Add(checkBoxSous.Text);
                if (checkBoxZeytun.Checked)
                    additions.Add(checkBoxZeytun.Text);

                cashForPizza += additions.Count; // elavelerin qiymete daxili 

                foreach (var item in additions)
                {
                    icindekiler += $"{item},";
                }

                if (icindekiler =="")
                {
                    icindekiler = "elave hec ne yoxdur.";
                }
               
                pizzaOrderForList = $"Pizza-{selectedPizza.Name}, {count}-eded, {SizePizzaCombo.SelectedItem.ToString()}-olcude, elaveler - {icindekiler}, Qiymet:\t {cashForPizza.ToString()} AZN ";

                totalAmount += cashForPizza;
                OrderList.Items.Add(pizzaOrderForList);
                additions.Clear();
                cashForPizza = 0;
            }
            else
            {
                MessageBox.Show($"Please select Pizza and Size, also count of your order !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void AddDrink_Click(object sender, EventArgs e)
        {
            if (DrinkCombo.SelectedItem != null &&  numericUpDown2.Value != 0)
            {

                decimal countForDrink = numericUpDown2.Value;
                decimal onePriceForDrink = 0;

                SoftDrink selectedDrink = new SoftDrink
                {
                    Name = DrinkCombo.SelectedItem.ToString(),

                };

                for (int i = 0; i < drinks.Count; i++) // loop secdiyimiz drinke uygun birinin qiymetini teyin etmek ucundur...
                {
                    SoftDrink temp = drinks[i];
                    if (selectedDrink.Name == temp.Name)
                    {
                        switch (DrinkCombo.SelectedItem.ToString())
                        {
                            case "Fanta":
                                onePriceForDrink = temp.Price;
                                break;
                            case "Cola":
                                onePriceForDrink = temp.Price;
                                break;
                            case "Redbull":
                                onePriceForDrink = temp.Price;
                                break;
                            case "Vitamin":
                                onePriceForDrink = temp.Price;
                                break;
                        }
                        break;
                    }
                }

                cashForDrink = countForDrink * onePriceForDrink;
                drinkOrderForList = $"Drink - {selectedDrink.Name}, {countForDrink} eded, Qiymet:\t {cashForDrink} AZN";

                totalAmount += cashForDrink;
                OrderList.Items.Add(drinkOrderForList);
                cashForDrink = 0;
            }
            else
            {
                MessageBox.Show($"Please select drink and count !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            ReceiptCash.Text = totalAmount.ToString();
        }
    }
}
