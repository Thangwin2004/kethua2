using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
             Circle circle = new Circle(2.5, "blue");
        Console.WriteLine(circle.ToString());

        Cylinder cylinder = new Cylinder(2.5, "blue", 5.0);
        Console.WriteLine(cylinder.ToString());
        }
    }
}
