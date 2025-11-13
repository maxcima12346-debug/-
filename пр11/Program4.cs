using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен быть больше 0!");
                    radius = 1;
                }
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
        public static void Main(string[] args)
        {
            Circle myCircle = new Circle(5);
            myCircle.GetArea();
            myCircle.Radius = -2; 
            myCircle.GetArea();   
        }
    }
}