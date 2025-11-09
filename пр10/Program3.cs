using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Device
{
    private string _brand;
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }
    public Device(string brand)
    {
        Brand = brand;
    }
    public void PowerOn()
    {
        Console.WriteLine($"{Brand} включён.");
    }
}
public class Laptop : Device
{
    private int _ram;
    private int _battery;
    public int Ram
    {
        get { return _ram; }
        set
        {
            if (value >= 1 && value <= 64)
            {
                _ram = value;
            }
            else
            {
                Console.WriteLine("ОЗУ должно быть от 1 до 64!");
            }
        }
    }
    public int Battery
    {
        get { return _battery; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _battery = value;
            }
            else
            {
                Console.WriteLine("Заряд батареи должен быть от 0 до 100!");
            }
        }
    }
    public Laptop(string brand, int ram, int battery) : base(brand)
    {
        Ram = ram;
        Battery = battery;
    }
    public void Work()
    {
        Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop("Dell", 16, 85);
        laptop.PowerOn();
        laptop.Work();

        Laptop invalidLaptop = new Laptop("HP", 0, 50); //Проверка на недопустимый объем RAM
    }
}
