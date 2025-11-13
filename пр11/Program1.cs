using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть от 0 до 120!");
                    age = 0; 
                }
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
        }
        public static void Main(string[] args)
        {
            Person person1 = new Person("Маша", 25);
            person1.SayHello();
            Person person2 = new Person("Иван", 150); 
            person2.SayHello();
            Person person3 = new Person("Петр", -5); 
            person3.SayHello();
        }
    }
}
