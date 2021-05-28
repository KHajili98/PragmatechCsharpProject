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
        public decimal volume;
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


            volume =PoolProperties.GetVolume(height, length, width);
            VolumeLabel.Text = volume.ToString();

            if (volume!=0)
            {
                groupBoxTime.Enabled = true;
                groupBoxVolume.Enabled = false;
            }
            else
            {
                MessageBox.Show($"Volume cannot be 0 !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void calculateTime_Click(object sender, EventArgs e)
        {
            var pipe1 = numericPipe1.Value;
            var pipe2 = numericPipe2.Value;

            if (pipe1 == 0&&pipe2==0)
            {
                MessageBox.Show($"Both of pipes cannot be 0 !", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var elapsedTime = PoolProperties.CalculateTime(volume, pipe1, pipe2);
                TimeLabel.Text = elapsedTime.ToString();
            }

           
        }
    }
}
