using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charging_Of_Pool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxVolume_Enter(object sender, EventArgs e)
        {
            groupBoxTime.Enabled = false;


        }

        private void btnCalculateVolume_Click(object sender, EventArgs e)
        {

            var height = numericForHeight.Value;
            var width = numericForWidth.Value;
            var length = numericForLength.Value;


            var volume =PoolProperties.GetVolume(height, length, width);
            VolumeLabel.Text = volume.ToString();
            groupBoxTime.Enabled = true;
            groupBoxVolume.Enabled = false;


        }
    }
}
