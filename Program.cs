using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.setColor("Red");
            circle.setRadius(2);
            Console.WriteLine(circle.getColor());
            Console.WriteLine(circle.getRadius());
        }
    }
}