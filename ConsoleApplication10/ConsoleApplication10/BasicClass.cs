using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public abstract class BasicClass
    {
        protected double balance;
        public int number;
        protected int pin;
        public virtual void addMoney(double count) { balance += count; }
        public virtual double getMoney(double count) { balance -= count; return count; }
        public virtual double checkBalance() { return balance; }

    }
}
