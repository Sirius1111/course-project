using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task_Click(object sender, EventArgs e)
        {
            Content task1 = new Content();
            task1.title = "Наследование";
            task1.text = "Тестировать конструкции наследовани и Доступ к членам класса";
            PrintText(task1.title, titleTheme);
            PrintText(task1.text, description);
            
        }

        async void  PrintText(string text, Label label) 
        {
            label.Text = "";
            string [] str = text.Split();
            code.Text = "";
            for (int i = 0; i < str.Length; i++)
            { 
               label.Text += (str[i] + " ");
               await Task.Delay(300);
            }
        }

   
        private void button2_Click_1(object sender, EventArgs e)
        {
            Content task2 = new Content();
            task2.title = "Виртуальные методы и их переопределение";
            task2.text = "Решить 2 задачи из файла \"Для самостоятельного решения\"";
            PrintText(task2.title, titleTheme);
            PrintText(task2.text, description);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var c = new Change();
            c.Show();
        }

        private void nextStep_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loader = new loader();
            loader.Show();
        }
    }
}
