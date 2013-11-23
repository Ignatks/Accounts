using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication10
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SavingAccount");
            //Console.WriteLine("------------------------------------");
            //SavingAccount sav = new SavingAccount(0.2d,DateTime.Now.AddMilliseconds(1000d));
            //sav.addMoney(1000d);
            //Check(sav.checkBalance(), 1000d, "Add money");
            //Check(sav.getMoney(100d), 100d, "Take money");
            //Thread.Sleep(1500);
            //Check(sav.getMoney(800),960,"Take money after");
            //Check(sav.getMoney(80000), 0, "Overdraft");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("TimedMaturuityAccount");
            //Console.WriteLine("------------------------------------");
            //TimedMaturuityAccount tacc = new TimedMaturuityAccount(DateTime.Now.AddMilliseconds(1000d), 0.2);
            //tacc.addMoney(1000d);
            //Check(tacc.checkBalance(), 1000d, "Add money");
            //Check(tacc.getMoney(100d), 120d, "Take money");
            //Thread.Sleep(1500);
            //Check(tacc.getMoney(800),800,"Take money after");
            //Check(tacc.getMoney(80000), 0, "Overdraft");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("TimedMaturuityAccount");
            //Console.WriteLine("------------------------------------");
            //OverdraftAccount overacc = new OverdraftAccount(new TimeSpan(0, 0, 0, 0, 1000), 0.2);
            //overacc.addMoney(1000d);
            //Check(overacc.checkBalance(), 1000d, "Add money");
            //Check(overacc.getMoney(1200d), 1200d, "Take money");
            //Thread.Sleep(1500);
            //Check(overacc.checkBalance(), -240, "Check balanace");
            //Check(overacc.getMoney(80000), 80000, "Overdraft");
        }
        static void Check(double var1, double var2, string desc)
        {
            if (var1 == var2)
                Console.WriteLine(desc + " - OK");
            else
                Console.WriteLine(desc + " - FAIL");
        }
    }
}
