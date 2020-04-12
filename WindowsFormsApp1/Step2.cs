using System;
using System.Collections;
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
    public partial class Step2 : Form
    {
        ReadWriteFile file = new ReadWriteFile();
        //Обычный массив
        //public static Object[] list = new object[1];

        //Массив ArrayList
        public static ArrayList list = new ArrayList();

        public Step2()
        {
            InitializeComponent();
        }

        private void Step2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Step2_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_MouseEnter(object sender, EventArgs e)
        {
            sendBtn.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void sendBtn_MouseLeave(object sender, EventArgs e)
        {
            sendBtn.ForeColor = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(198)))), ((int)(((byte)(45)))));

        }

        private void uploadBtn_MouseEnter(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

        }

        private void uploadBtn_MouseLeave(object sender, EventArgs e)
        {
            uploadBtn.ForeColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();
            string tel = telInput.Text.Trim();
            string dataInput;

            if (name.Length == 0 && tel.Length == 0)
            {
                MessageBox.Show("Введите корректные значения");
            } else {
                if (man.Checked){
                    var man = new Men(name, tel);
                    list.Add(man);
                    dataInput = man.name + "|" + man.tel + "|" + man.dateTime +"|man";
                } else if (woman.Checked){
                    var woman = new Women(name, tel);
                    list.Add(woman);
                    dataInput = woman.name + "|" + woman.tel + "|" + woman.dateTime + "|woman";
                } else {
                    MessageBox.Show("Выберите пол");
                    return;
                }

                // Обычный массив-----------------------------
                //var people = new People(name, tel);
                //list[people.getCount()] = people;
                //Array.Resize<object>(ref list, list.Length+1);
                //--------------------------------------------

                file.Write(dataInput);


                nameInput.Text = "";
                telInput.Text = "";
            }
        }
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ArrayList dataOutput;
            string pathTextFile = "";
            try
            {
                uploadFileDialog.ShowDialog();
                pathTextFile = uploadFileDialog.FileName;
                dataOutput = file.ReadFilePath(pathTextFile);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }

            foreach (string item in dataOutput)
            {
                var str = item.Split('|');

                string name = str[0].Trim();
                string tel = str[1].Trim();
                string gender = str[str.Length - 1].Trim();
                if (gender.ToLower() == "man")
                {
                    var man = new Men(name, tel);
                    list.Add(man);
                } else {
                    var woman = new Women(name, tel);
                    list.Add(woman);
                }
                // Обычный массив-----------------------------
                //var people = newPpeople(name, tel);
                //list[people.getcount()] = people;
                //array.resize<object>(ref list, list.length + 1);
                //--------------------------------------------
            }
        }
        private void ChangeGender(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void getMenData_Click(object sender, EventArgs e)
        {
            string data = "";
            int count = 0;
            ArrayList deleteIndexElements = new ArrayList();
            list.ToArray();
            foreach (People item in list)
            {
                if (item.GetType().Name.ToLower() == "men") { 
                    data += item.name + "\n";
                    deleteIndexElements.Add(count);
                }
                count++;
            }

            for (int i = deleteIndexElements.Count-1; i >= 0; i--)
            {
                list.Remove(list[(int)deleteIndexElements[i]]);
            }
            if(data == "") {
                MessageBox.Show("Мужчины не найдены");
            } 
            else
            {
                MessageBox.Show(data);

            }
        }
    }
    class Men : People
    {
        public string dateTime;
        public Men(string name, string tel) : base(name, tel)

        {
            count++;
            this.name = name;
            this.tel = tel;
            this.dateTime = DateTime.Now.ToShortDateString();
        }
    }
    class Women: People
    {
        public string dateTime;
        public Women(string name, string tel) : base(name, tel)
        {
            count++;
            this.name = name;
            this.tel = tel;
            this.dateTime = DateTime.Now.ToShortDateString();
        }
    }
    class People
    {
        public static int count = -1;
        public string name, tel;
        public People(string name, string tel)
        {
            count++;
            this.name = name;
            this.tel = tel;
        }

        public int getCount()
        {
            return count;
        }
    }
}
