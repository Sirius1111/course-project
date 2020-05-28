using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class GuitarPlant : Form
    {
        Plant plant1 = new Plant("Завод 1", 50);
        Plant plant2 = new Plant("Завод 2", 10);
        Plant plant3 = new Plant("Завод 3", 70);
        Plant plant4 = new Plant("Завод 4", 40);
        Plant plant5 = new Plant("Завод 5", 100);
        Plant plant6 = new Plant("Завод 6", 89);
        
        OldPlant Oldplant1 = new OldPlant("Завод 1", 50);
        OldPlant Oldplant2 = new OldPlant("Завод 6", 89);
        OldPlant Oldplant3 = new OldPlant("Завод 2", 10);
        NewPlant Newplant1 = new NewPlant("Завод 3", 70, "Струны, Усилитель");
        NewPlant Newplant2 = new NewPlant("Завод 4", 40, "Нет Информации");
        NewPlant Newplant3 = new NewPlant("Завод 5", 100, "Медиаторы");
        public GuitarPlant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] plants = new object[6] { plant1, plant2, plant3, plant4, plant5, plant6 };
            ArrayList sortlist = new ArrayList();
            foreach (object item in plants)
            {
                sortlist.Add(item);
            }   
            comboBox2.Items.Clear();
            Plant plant = new Plant();
            IComparer comparer = plant;
            sortlist.Sort(comparer);
            foreach (var item in sortlist)
            {
                plant = item as Plant;
                comboBox2.Items.Add(plant.name+ "|" + plant.products);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] plants = new object[6] { Oldplant1,Oldplant2, Oldplant3, Newplant1, Newplant2, Newplant3};
            foreach (var item in plants)
            {
                if ((item.GetType() == typeof(OldPlant)) || (item.GetType() == typeof(NewPlant)))
                {
                    ICosei cost = (ICosei)item;
                    cost.Cost();
                }
            }
        }
    }
    class Plant : Object, IComparer
    {
        public int products;
        public string name;
        public Plant() { }
        public Plant(string name, int products)
        {
            this.name = name;
            this.products = products;
        }
        public int Compare(object x, object y)
        {
            if (((Plant)x).products > ((Plant)y).products) return 1;
            else if (((Plant)x).products < ((Plant)y).products) return -1;
            else return 0;
        }
    }
    interface ICosei
    {
        void Cost();
    }
    class NewPlant : Plant, ICosei
    {
        public string product;
        public NewPlant(string name, int products ,string product="Струны") : base (name, products)
        {
            this.product = product;
        }
        public void Cost() 
        {
            MessageBox.Show("На заводе " + name + "- " + products + " шт. Различных принадлежностей для гитары\n" + product);
        }
    }
    class OldPlant : Plant, ICosei
    { 
        public void Cost()
        {
            MessageBox.Show("На заводе " + name + "- " + products + " шт. Гитар");
        }
        public OldPlant(string name, int products) : base(name, products){ }
    }
}
