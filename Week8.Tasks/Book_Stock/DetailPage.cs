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
    public partial class DetailPage : Form
    {
        private Form1 form1;
        public DetailPage(Book passingBook)
        {
            InitializeComponent();
        }

        

        private void DetailPage_Load(object sender, EventArgs e)
        {
            NameInput.Text = Form1.SelectedItem.Name;
            categoryInput.Text = Form1.SelectedItem.Category;
            stockCountInput.Text = Form1.SelectedItem.StockCount;
            authorInput.Text = Form1.SelectedItem.Author;
            descInput.Text = Form1.SelectedItem.Description;
            pictureBox1.ImageLocation = Form1.SelectedItem.Image;
           

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {

            Form1.books.Remove(Form1.SelectedItem);
            Book updatedBook = new Book
            {
                Name=NameInput.Text,
                Category = categoryInput.Text,
                StockCount = stockCountInput.Text,
                Author = authorInput.Text,
                Description = descInput.Text,
            };
            Form1.books.Add(updatedBook);
            var lastBooks = Form1.books;
            form1 = new Form1(lastBooks);
            form1.Show();
            this.Hide();

        }
    }
}
