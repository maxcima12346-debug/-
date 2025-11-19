using System;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string position, decimal salary, DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            HireDate = hireDate;
        }
        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Должность: {Position}, Зарплата: {Salary}, Дата приема: {HireDate.ToString("dd.MM.yyyy")}";
        }
    }
    class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, string position, decimal salary, DateTime hireDate, int teamSize) : base(name, position, salary, hireDate)
        {
            TeamSize = teamSize;
        }
        public void ConductMeeting()
        {
            Console.WriteLine($"Менеджер {Name} проводит собрание команды из {TeamSize} человек.");
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Размер команды: {TeamSize}";
        }
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Developer(string name, string position, decimal salary, DateTime hireDate, string programmingLanguage) : base(name, position, salary, hireDate)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public void WriteCode(string task)
        {
            Console.WriteLine($"Разработчик {Name} пишет код на {ProgrammingLanguage} для задачи: {task}");
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Язык программирования: {ProgrammingLanguage}";
        }
    }
    class Director : Employee
    {
        public string Department { get; set; }
        public Director(string name, string position, decimal salary, DateTime hireDate, string department) : base(name, position, salary, hireDate)
        {
            Department = department;
        }
        public void ApproveBudget(decimal amount)
        {
            Console.WriteLine($"Директор {Name} утвердил бюджет в размере {amount} для отдела {Department}.");
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Отдел: {Department}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hireDate = new DateTime(2023, 10, 26);
            Manager manager = new Manager("Иван Петров", "Менеджер проекта", 120000, hireDate, 10);
            Developer developer = new Developer("Анна Сидорова", "Разработчик", 100000, hireDate, "C#"); 
            Director director = new Director("Сергей Иванов", "Директор", 200000, hireDate, "Разработка");
            Console.WriteLine(manager.GetInfo());
            manager.ConductMeeting();
            Console.WriteLine(developer.GetInfo());
            developer.WriteCode("Разработка API");
            Console.WriteLine(director.GetInfo());
            director.ApproveBudget(5000000);
            Console.ReadKey(); 
        }
    }
}
