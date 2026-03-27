using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {

        List<RoundShape> RStones = new List<RoundShape>();

        RStones.Add(new Circle(2.0));
        RStones.Add(new Cylinder(10.0, 2.0));
        RStones.Add(new Sphere(500));

        foreach (RoundShape shape in RStones)
        {
            Console.WriteLine($"Area of shape: {shape.Area()}");

        }


        // Circle steve = new Circle(2.0);
        // Cylinder mike = new Cylinder(10.0, 2.0);
        // Sphere sully = new Sphere(500);
        // Console.WriteLine($"Area of steve: {steve.Area()}");
        // Console.WriteLine($"Area of mike: {mike.Area()}");
        // Console.WriteLine($"Area of sully: {sully.Area()}");
    }
}
