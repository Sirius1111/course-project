using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //********************
    //1 заданние -----------||||||15|||||---------
    // abstaract class Guitar
    //********************
    class Guitar
    {
        public string model { get; set; }
        public int priceBox = 300;
        public int id;

        public Guitar()
        {
            model = "0";
            id = 0;
        }
        public Guitar(string m)
        {
            model = m;
        }
        public Guitar(string m, int i)
        {
            model = m;
            id = i;
        }
        public Guitar(string m, int i, int p)
        {
            model = m;
            id = i;
            priceBox = p;
        }
        public string getInfo()
        {
            string str = "";
            string type = ""; 
            if(Electro.getType() == "")
            {
                type = "Классическая";
            } else
            {
                type = Electro.getType();
            }
            str = $"Модель: {model}, Тип: {type}\n id: {id}, Цена за упоковку: {priceBox} руб";
            return str;
        }
    }
    class ClassicalGuitar : Guitar
    {
        static public string type = "";
        public ClassicalGuitar()
        {
            type = "Classic";
        }
        public ClassicalGuitar(string m, int i) : base(m, i)
        {}
        static public string getType()
        {
            return type;
        }
    }
    class Electro : Guitar
    {
        static public string type = "";
        public Electro()
        {
            type = "standart" ;
        }
        public Electro(string m, int i, int p, string t):base(m,i,p)
        {
            type = t;
        }
        static public string getType()
        {
            return type;
        }
    }
    class NewElectro : Electro
    {
        new int priceBox;
        public NewElectro(int p)    
        {
            priceBox = p;
        }
        public NewElectro(int newP, int oldPrice)
        {
            base.priceBox = oldPrice;
            priceBox = newP;
        }

        public string Show()
        {
            string str = $"Старая цена {base.priceBox}, новая цена {priceBox}";
            return str;
        }

    }
}

