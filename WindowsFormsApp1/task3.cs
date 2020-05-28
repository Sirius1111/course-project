using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class TwoDShape
{
    public double pri_width;
    public double pri_height;
    // Конструктор по умолчанию.
    public TwoDShape()
    {
        Width = Height = 0.0;
    }
    // Конструктор для класса TwoDShape.
    public TwoDShape(double w, double h)
    {
        Width = w;
        Height = h;
    }
    // Сконструировать объект равной ширины и высоты.
    public TwoDShape(double x)
    {
        Width = Height = x;
    }
    // Свойства ширины и высоты объекта.
    public double Width
    {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }
    public double Height
    {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }
    public string ShowDim()
    {
        string str = "Ширина и высота равны " + Width + " и " + Height;
        return str;
    }
}
    // Класс для треугольников, производный от класса TwoDShape.
    class Triangle : TwoDShape
    {
        string Style;
        new double pri_width = 0;
        new double pri_height = 0;
        // Конструктор, используемый по умолчанию.
        public Triangle()
        {
            Style = "null";
        }
        // Вызвать конструктор базового класса.
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
            base.pri_width = w;
            base.pri_height = h;
        }

        // Сконструировать равнобедренный треугольник.
        public Triangle(double x) : base(x)
        {
            Style = "равнобедренный";
        }

        public double Area()
        {
            return Width * Height / 2;
        }
        // Показать тип треугольника.
        public string ShowStyle()
        {
            string str = "Треугольник " + Style + "\n";
            return str;
        }
        // Расширить класс Triangle. 
    }
    //Класс цвнт производны от Triabgle.
    

}
