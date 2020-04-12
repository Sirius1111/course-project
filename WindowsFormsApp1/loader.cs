using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }


        private void timerLoader_Tick(object sender, EventArgs e)
        {
            panelLine.Width += 5;
            if(loaderDots.Text == "...")
            {
                loaderDots.Text = "";
            } else
            {
                loaderDots.Text += ".";
            }
            if (panelLine.Width >= panelLoader.Width-1)
            {
                timerLoader.Stop();
                var f2 = new Step2();
                this.Hide();
                f2.Show();
            }
        }


    }
}
