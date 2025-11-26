using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat();
        }
    }
}
