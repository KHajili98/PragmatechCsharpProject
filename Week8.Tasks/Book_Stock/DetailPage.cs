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
        public DetailPage(Book passingBook)
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

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
    }
}
