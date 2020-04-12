using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class TwoDShape
{
    double pri_width;
    double pri_height;
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
    // Сконструировать копию объекта TwoDShape.
    public TwoDShape(TwoDShape ob)
    {
        Width = ob.Width;
        Height = ob.Height;
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
        // Конструктор, используемый по умолчанию.
        public Triangle()
        {
            Style = "null";
        }
        // Конструктор для класса Triangle.
        public Triangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }
        // Сконструировать равнобедренный треугольник.
        public Triangle(double x) : base(x)
        {
            Style = "равнобедренный";
        }
        // Сконструировать копию объекта типа Triangle.
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }
        // Возвратить площадь треугольника.
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
    }
}
