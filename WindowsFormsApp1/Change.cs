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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //По клику на кнопки будем создать обьект класса guiltar, после этого перенаправлять на форму оформления заявки.
            Guitar guitar1;
            NewElectro newElectro = new NewElectro(8);

            //класс NewElectro является производным от класса Guitar, 
            //поэтому мы имеем право так делать. Если бы класс NewElectro
            // не бы бы производным от класса Guitar, но имел такую же структуру, то это была бы ошибка.
            guitar1 = newElectro;
            string info = guitar1.getInfo();
            value.Text = info;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //В данном случае увидим, что обьекту базового класса можно присвоить объект наследоваемого класса, в данном случае Electro
            Guitar guitar1 = new Electro("zx1004", 8, 500,"Электро гитара");
            string info = guitar1.getInfo();
            value.Text = info;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //А тут мы покажем пользователю, что цена на товар изменилась, и в данный момент товар отсутсвует
            NewElectro guitar2 = new NewElectro(500, 300);
            value.Text = "Сейчас на этот товар новая цена\n" + guitar2.Show() + "\n этот товар отсутствует, вы будете перенаправлены на начальную страницу.";
        }
        private void Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void next(object sender, EventArgs e)
        {
            //Переход на следующую форму
            timer1.Stop();
            var load = new loader();
            this.Hide();
            load.Show();
        }

        private void Change_Load(object sender, EventArgs e)
        {
            GuitarFamily guitar1 = new GuitarFamily("Classical", "C-80", 1);
            GuitarFamily guitar2 = new GuitarFamily("Electro", "Fender Bass V", 3);
            GuitarFamily guitar3 = new GuitarFamily("Acoustic", "Ibanez", 2);

            string str = "В наличии: \n" + guitar1.ui() + guitar2.ui() + guitar3.ui();
            MessageBox.Show(str, "В наличии");
        }
    }

    // Создаем абстрактный класс
    abstract class GuitarInfo
    {
        protected string Model;
        protected byte Age;

        public GuitarInfo(string Model, byte Age)
        {
            this.Model = Model;
            this.Age = Age;
        }

        // Абстрактный метод
        public abstract string ui();
    }

    class GuitarFamily : GuitarInfo
    {
        string Family;

        public GuitarFamily(string Family, string Model, byte Age) : base(Model, Age)
        {
            this.Family = Family;
        }

        // Переопределяем метод ui
        public override string ui()
        {
            return Family + " Model: " + Model + " age: " + Age +  "year\n";
        }
    }
}
