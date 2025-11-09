using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    private string _name;
    private double _salary;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 0 && value <= 1_000_000)
            {
                _salary = value;
            }
            else
            {
                Console.WriteLine("Зарплата должна быть в диапазоне от 0 до 1 000 000!");
            }
        }
    }
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    public Employee(string name) : this(name, 50000)
    {
       
    }
    public void Work()
    {
        Console.WriteLine($"{Name} работает, зарплата: {Salary}.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Иван", 80000);
        Employee employee2 = new Employee("Анна");
        employee1.Work();
        employee2.Work();
        Employee invalidEmployee = new Employee("Проблемный работник", -1000); 
    } 
} 