using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    public class Circle
    {
        private double Radius = 1.0;
        private string Color = "Red";
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public Circle()
        {

        }
        public void setRadius(double radius)
        {
            Radius = radius;
        }
        public double getRadius()
        {
            return Radius;
        }
        public void setColor(string color)
        {
            Color = color;
        }
        public string getColor()
        {
            return Color;
        }
    }
}