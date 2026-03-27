using System;

class Program
{
    static void Main(string[] args) // make 2 orders with 2 products each
    {
        Order order1 = new Order();
        order1.SetCustomer("bill","1045 W horne", "Phoenix", "AZ", "USA");
        order1.AddProduct("Spiderman lava-lamp","1564SY",6,1);
        order1.AddProduct("Evaporated water","14891PE", 20, 3);
        order1.DisplayAll();

        Order order2 = new Order();
        order2.SetCustomer("Sarobidy","2046 E Bera", "Ampitarano", "Ansirabe", "Madagascar");
        order2.AddProduct("Rotating fan","48748FY",15,2);
        order2.AddProduct("Long grain rice(5Lb)","46703LA", 10, 1);
        order2.DisplayAll();
        

    }
}