using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка...");
        }
    }
    class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень-брень!");
        }
    }
    class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-бум!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band) i.Play();
           
        }
    }
}
