using Tumakov.Enums;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        private static void Task1()
        {
            Console.WriteLine("упражнение 8.1");
            var account1 = new Bank(1000, AccountType.current);
            var account2 = new Bank(500, AccountType.current);
            account1.Transfer(account2, 300);
            account1.PrintAccount();
        }
        private static void Task2()
        {
            Console.WriteLine("Упражнение 8.2");
            Console.WriteLine("Введи строку:");
            string line = Console.ReadLine();
            string reverseLine = ReverseOrder(line);
            Console.WriteLine($"Перевернутая строка:{reverseLine}");
        }
        public static string ReverseOrder(string line)
        {
            char[] chars = line.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        private static void Task3()
        {
            Console.WriteLine("Упражнение 8.3");
            Console.WriteLine("Введи название файла");
            string nameFile = Console.ReadLine();
            try
            {
                var text = File.ReadAllText("../../../Files/" + nameFile + ".txt");
                File.WriteAllText("../../../Files/File2.txt", text.ToUpper());
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        private static void Task4()
        {
            Console.WriteLine("Упражнение 8.4");
            int number = 89;
            string text = "butterfly";
            Console.WriteLine($"{IsIFormattable(number)}");
            Console.WriteLine($"{IsIFormattable(text)}");
        }
        public static bool IsIFormattable(object set)
        {
            return set is IFormattable;
        }
        public static bool AsIFormattable(object set)
        {
            var formattableSet = set as IFormattable;
            return formattableSet != null;
        }
    }
}