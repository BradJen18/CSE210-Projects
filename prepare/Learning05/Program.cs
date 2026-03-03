using System;
using System.ComponentModel;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
       List<Shapes> Shapes = new List<Shapes>();

       Shapes.Add(new Shapes("Red"));
       Shapes.Add(new Square("Blue", 2));
       Shapes.Add(new Rectangle("Green",2,3));
       Shapes.Add(new Circle("Yellow", 1));

       foreach(Shapes shapes in Shapes)
        {
            double area = shapes.GetArea();
            string color = shapes.GetColor();
        

            Console.WriteLine($"{color} - {area}");
        }
    }
}