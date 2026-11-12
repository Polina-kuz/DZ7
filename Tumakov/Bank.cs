using Tumakov.Enums;
namespace Tumakov
{
    public class Bank
    {
        private string number;
        private decimal balance;
        private AccountType type;
        private static long numberr = 1000000;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public AccountType Type
        {
            get { return type; }
            set { type = value; }
        }
        public Bank(string nnumber, decimal bbalance, AccountType ttype)
        {
            Number = nnumber;
            Balance = bbalance;
            Type = ttype;
        }
        public Bank(decimal balancee, AccountType typee)
        {
            number = GenerateNumber();
            Balance = balancee;
            Type = typee;
        }
        private string GenerateNumber()
        {
            return (numberr++).ToString();
        }
        public void PrintAccount()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
        public void Deposit(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount} зачислено на счет");
        }
        public bool Withdrawal(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} снято со счета");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                return false;
            }
        }
        public bool Transfer(Bank bank2,decimal sum)
        {
            if (balance >= sum && sum > 0)
            {
                balance += sum;
                bank2.balance += sum;
                Console.WriteLine($"{sum} рублей переведено на другой банковский счет");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                return false;
            }
        }
    }
}
