using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Content : Form1
    {
        public string title {get; set;}
        public string text  {get; set;}
        public void ShowThis(string name, string text)
        {
            titleTheme.Text = name;
            description.Text = text;
        }
    }
}
