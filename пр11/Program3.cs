using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BankAccount
    {
        private string owner;
        private double balance;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Баланс не может быть отрицательным!");
                    balance = 0; 
                }
            }
        }
        public BankAccount(string owner, double initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть больше 0.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"{Owner}, баланс: {Balance}.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств!");
                }
            }
            else
            {
                Console.WriteLine("Сумма снятия должна быть больше 0.");
            }
        }
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Иван", 1000);

            account.Deposit(500);
            account.Withdraw(500);
            account.Withdraw(1500); 
            account.Withdraw(100); 
        }
    }
}