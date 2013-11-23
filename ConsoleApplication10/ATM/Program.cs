using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication10;

namespace ATM
{
    public class Program
    {

        static List<Tuple<BasicClass, int>> list;
        static void Main(string[] args)
        {
            FillAccounts();
            Tuple<BasicClass, int> accPair;
            BasicClass account;
            bool cycle = true;
            Console.WriteLine("Введите номер аккаунта\n");
            int accountNumber = int.Parse(Console.ReadLine());
            try
            {
                accPair = list.Where(t => t.Item1.number == accountNumber).First();
            }
            catch(Exception)
            {
                Console.WriteLine("Неверный номер");
                return;
            }
            Console.WriteLine("Введите pin");
            int pin = int.Parse(Console.ReadLine());
            if (accPair.Item2 == pin)
            {
                account = accPair.Item1;
            }
            else
            {
                Console.WriteLine("Неверный pin");
                return;
            }
            while (cycle)
            {
                Console.WriteLine("1 - Проверить баланс\n2 - Положить деньги\n3 - Снять деньги\n4 - выйти\n");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(account.checkBalance());
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Введите кол-во");
                        int count = int.Parse(Console.ReadLine());
                        account.addMoney(count);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Введите кол-во");
                        int count1 = int.Parse(Console.ReadLine());
                        double money = account.getMoney(count1);
                        Console.WriteLine("Вы получили {0} денег", money);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        cycle = false;
                        break;
                    default:
                        break;
                }
               
 
            }
        }


             
        static public void FillAccounts()
        {
            list = new List<Tuple<BasicClass, int>>();
            list.Add(new Tuple<BasicClass,int>(new SavingAccount(0.2, DateTime.Now.AddMinutes(2), 214, 1234),2134));
        }
    }
}
