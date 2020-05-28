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
    public partial class ListProducts : Form
    {
        // Создадим структуру
        struct ProductGuitarInfo
        {
            public string Name;
            public string State;

            public ProductGuitarInfo(string Name, string State)
            {
                this.Name = Name;
                this.State = State;
            }
            public void ShowLastProductInfo(ProductGuitarInfo product)
            {
                MessageBox.Show("Last Product:\nGuitar Name:" + product.Name + "\nState Product: " + product.State);
            }public void ShowLProductInfo()
            {
                MessageBox.Show("Guitar Name:" + Name + "\nState Product: " + State);
            }
        }

        ProductGuitarInfo guitar = new ProductGuitarInfo();

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
;           string state = stateInput.Text;
            var isNotNull = false;

            if (name.Trim() == "")
            {
                MessageBox.Show("Введите наименование гитары");
                isNotNull = true;
            } else {
                isNotNull = false;
            }
            if (state.Trim() == "")
            {
                MessageBox.Show("Введите состояние гитары");
                isNotNull = true;
            }else {
                isNotNull = false;
            }

            if (isNotNull)
            {
                ProductGuitarInfo guitar1 = new ProductGuitarInfo(name, state);
                ReadWriteFile file = new ReadWriteFile();
                file.Write(guitar1.Name + "|" + guitar1.State, "Data");
                guitar = guitar1;
            }
        }

        private void PrintDataButton_Click(object sender, EventArgs e)
        {
            if(guitar.Name == "" || guitar.State == "")
            {
                MessageBox.Show("Введите данные");
            } else {
                guitar.ShowLastProductInfo(guitar);
            }
        }
        private void PrintRandomGuitars_Click(object sender, EventArgs e)
        {
            ProductGuitarInfo guitar1 = new ProductGuitarInfo("guitar1", "good");
            guitar1.ShowLProductInfo();
            ProductGuitarInfo guitar2 = new ProductGuitarInfo("guitar2", "bad");
            guitar2.ShowLProductInfo();
            // Показать главное отличие структур от классов
            guitar1 = guitar2;
            guitar2.Name = "guitar3";
            guitar2.State = "Very good";
            guitar1.ShowLProductInfo();
            guitar2.ShowLProductInfo();
        }

    enum GuitarsMaker { Yamaha, Washburn, Vox, Lakland, Hohner, DeanGuitars };

    private void ListProducts_Load(object sender, EventArgs e)
    {
        string str = "";
        string[] guitarsTypes = {
                "Электро-гитара",
                "Классическая гитара",
                "Акустическая Гитара",
                "Полу-акустическая гитара",
                "Бас гитара",
                "Акулеле"
        };
        GuitarsMaker i; 
        // объявить переменную перечислимого типа
        // Использовать переменную i для циклического
        // обращения к членам перечисления.
        for (i = GuitarsMaker.Yamaha; i <= GuitarsMaker.DeanGuitars; i++)
            str += (i + " имеет значение " + (int)i) + "\n";
        // Использовать перечисление для индексирования массива.
        str += "\n";
        for (i = GuitarsMaker.Yamaha; i <= GuitarsMaker.DeanGuitars; i++)
            str +=  ("Производитель гитар " + i + " — " + guitarsTypes[(int)i]) + "\n";

        MessageBox.Show(str, "Производители гитар");
    }

        public ListProducts()
        {

            InitializeComponent();
        }
    }
}
