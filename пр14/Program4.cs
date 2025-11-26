using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }
    class Triangle : Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());
        }
    }
}
