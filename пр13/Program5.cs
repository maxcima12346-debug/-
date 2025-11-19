using System;
using System.Collections.Generic;
using System.Linq;
namespace ZooAccounting
{
    public abstract class Animal
    {
        public string Species { get; protected set; } 
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public Animal(string species, int age, string habitat, string diet)
        {
            Species = species;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
        public abstract void Eat();
        public virtual void MakeSound()
        {
            Console.WriteLine("Звук животного");
        }
    }
    public class Mammal : Animal
    {
        public string FurType { get; set; }
        public int GestationPeriod { get; set; }
        public Mammal(string species, int age, string habitat, string diet, string furType, int gestationPeriod)
            : base(species, age, habitat, diet)
        {
            FurType = furType;
            GestationPeriod = gestationPeriod;
        }
        public void GiveBirth()
        {
            Console.WriteLine($"{Species} рожает детенышей.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet} как млекопитающее.");
        }
    }
    public class Bird : Animal
    {
        public double Wingspan { get; set; }
        public string NestingType { get; set; }
        public Bird(string species, int age, string habitat, string diet, double wingspan, string nestingType)
            : base(species, age, habitat, diet)
        {
            Wingspan = wingspan;
            NestingType = nestingType;
        }
        public void Fly()
        {
            Console.WriteLine($"{Species} летит.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet} как птица.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Species} чирикает.");
        }
    }
    public class Reptile : Animal
    {
        public string SkinType { get; set; }
        public double AmbientTemperature { get; set; }
        public Reptile(string species, int age, string habitat, string diet, string skinType, double ambientTemperature)
            : base(species, age, habitat, diet)
        {
            SkinType = skinType;
            AmbientTemperature = ambientTemperature;
        }
        public void Bask()
        {
            Console.WriteLine($"{Species} греется на солнце.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet} как рептилия.");
        }
    }
    public class Fish : Animal
    {
        public string ScaleType { get; set; }
        public int Depth { get; set; }
        public Fish(string species, int age, string habitat, string diet, string scaleType, int depth)
            : base(species, age, habitat, diet)
        {
            ScaleType = scaleType;
            Depth = depth;
        }
        public void Swim()
        {
            Console.WriteLine($"{Species} плавает.");
        }
        public override void Eat()
        {
            Console.WriteLine($"{Species} ест {Diet} как рыба.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Mammal lion = new Mammal("Лев", 5, "Саванна", "Мясо", "Короткая шерсть", 110);
            Bird eagle = new Bird("Орел", 3, "Горы", "Мясо", 2.0, "На деревьях");
            Reptile snake = new Reptile("Змея", 2, "Джунгли", "Мыши", "Сухая чешуя", 28.0);
            Fish salmon = new Fish("Лосось", 4, "Река", "Водоросли", "Крупная чешуя", 10);
            lion.Eat();        
            eagle.Fly();       
            snake.Bask();       
            salmon.Swim();     
            eagle.MakeSound(); 
            lion.MakeSound();   
        }
    }
}
