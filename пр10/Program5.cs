using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Animal
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издаёт звук.");
    }
}
public class Cat : Animal
{
    private int _lives;
    public int Lives
    {
        get { return _lives; }
        set
        {
            if (value >= 1 && value <= 9)
            {
                _lives = value;
            }
            else
            {
                Console.WriteLine("Количество жизней должно быть от 1 до 9.");
            }
        }
    }
    public Cat(string name, int lives) : base(name)
    {
        Lives = lives;
    }
    public Cat(string name) : this(name, 9)
    {
    }
    public void Meow()
    {
        if (Lives > 1)
        {
            Lives--;
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
        }
        else if (Lives == 1)
        {
            Lives--;
            Console.WriteLine($"{Name} мяукнул, и потерял последнюю жизнь!");
        }
        else
        {
            Console.WriteLine($"{Name} уже мертв! Он не может мяукать.");
        }

    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Cat cat1 = new Cat("Мурзик", 1);
        Cat cat2 = new Cat("Барсик");
        cat1.Speak();
        cat1.Meow();
        cat1.Meow();
        cat1.Meow();
        cat2.Speak();
        cat2.Meow();
        cat2.Meow();
        cat1.Lives = 0; 
        Console.WriteLine($"{cat1.Name} имеет жизней: {cat1.Lives}");
    }
}

