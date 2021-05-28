using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Stock
{
    public partial class Form1 : Form
    {
        public static Book SelectedItem =null;
        private DetailPage detailPage;
        
        public Form1(List<Book> books)
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BooksListCombo.SelectedItem = null;
            BooksListCombo.SelectedText = "--------Select your book--------";
            foreach (var item in Book.books)
            {
                BooksListCombo.Items.Add(item.Name);
            }
            Console.WriteLine(BooksListCombo.SelectedItem);

        }

        private void showButton_Click(object sender, EventArgs e)
        {

            if (BooksListCombo.SelectedItem != null)
            {
                SelectedItem = Book.books.FirstOrDefault(b => b.Name == BooksListCombo.SelectedItem.ToString());
                detailPage = new DetailPage(SelectedItem);
                detailPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Please select Book !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        
            
        }
    }
}
