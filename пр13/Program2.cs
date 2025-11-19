using System;

namespace ConsoleApp1
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; protected set; } 
        public decimal Balance { get; protected set; }
        public string OwnerName { get; protected set; }
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount); 
        public abstract void CalculateInterest(); 
        public virtual string GetAccountInfo()
        {
            return $"Номер счета: {AccountNumber}, Владелец: {OwnerName}, Баланс: {Balance:C}"; 
        }
    }

    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }
        public CheckingAccount(string accountNumber, string ownerName, decimal initialBalance, decimal overdraftLimit) : base(accountNumber, ownerName, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной.");
                return;
            }
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount:C} со счета {AccountNumber}. Новый баланс: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств или превышен лимит овердрафта.");
            }
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма пополнения должна быть положительной.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Внесено {amount:C} на счет {AccountNumber}. Новый баланс: {Balance:C}");
        }
        public override void CalculateInterest()
        {
            Console.WriteLine("Для текущего счета проценты не начисляются.");
        }
    }
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; } 
        public SavingsAccount(string accountNumber, string ownerName, decimal initialBalance, decimal interestRate) : base(accountNumber, ownerName, initialBalance)
        {
            InterestRate = interestRate;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной.");
                return;
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount:C} со счета {AccountNumber}. Новый баланс: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма пополнения должна быть положительной.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Внесено {amount:C} на счет {AccountNumber}. Новый баланс: {Balance:C}"); 
        }
        public override void CalculateInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Начислены проценты в размере {interest:C} на счет {AccountNumber}. Новый баланс: {Balance:C}"); 
        }
    }
    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; private set; } 
        public int PaymentTermMonths { get; private set; } 
        public CreditAccount(string accountNumber, string ownerName, decimal initialBalance, decimal creditLimit, int paymentTermMonths) : base(accountNumber, ownerName, initialBalance)
        {
            CreditLimit = creditLimit;
            PaymentTermMonths = paymentTermMonths;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной.");
                return;
            }
            if (Balance + CreditLimit >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount:C} со счета {AccountNumber}. Новый баланс: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Превышен кредитный лимит.");
            }
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма пополнения должна быть положительной.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Внесено {amount:C} на счет {AccountNumber}. Новый баланс: {Balance:C}"); 
        }
        public override void CalculateInterest()
        {
            Console.WriteLine("Рассчет процентов по кредитной линии не реализован.");
        }
    }
}
