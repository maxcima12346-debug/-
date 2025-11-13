using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Phone
    {
        private string brand;
        private int batteryLevel;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    batteryLevel = value;
                }
                else
                {
                    Console.WriteLine("Заряд должен быть от 0 до 100!");
                    if (value < 0)
                    {
                        batteryLevel = 0;
                    }
                    else
                    {
                        batteryLevel = 100;
                    }
                }
            }
        }
        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void UsePhone()
        {
            batteryLevel -= 10;
            batteryLevel = Math.Max(0, batteryLevel);
            Console.WriteLine($"Телефон {Brand}, заряд: {batteryLevel}%.");
        }
        public static void Main(string[] args)
        {
            Phone myPhone = new Phone("Samsung", 90);
            myPhone.UsePhone();
            myPhone.UsePhone();
            myPhone.BatteryLevel = -10;
            myPhone.UsePhone();
        }
    }
}
