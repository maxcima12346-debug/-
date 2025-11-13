using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Pet
    {
        private string name;
        private int energy;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    energy = value;
                }
                else
                {
                    Console.WriteLine("Энергия должна быть от 0 до 100!");
                    if (value < 0)
                    {
                        energy = 0;
                    }
                    else
                    {
                        energy = 100;
                    }
                }
            }
        }
        public Pet(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }
        public void Play()
        {
            Energy -= 20;
            Console.WriteLine($"{Name} играет, энергия: {Energy}.");
        }
        public void Rest()
        {
            Energy += 30;
            Console.WriteLine($"{Name} отдыхает, энергия: {Energy}.");
        }
        public static void Main(string[] args)
        {
            Pet myPet = new Pet("Рекс", 80);
            myPet.Play();
            myPet.Rest();
            myPet.Energy = 150; 
            myPet.Play();        
        }
    }
}
