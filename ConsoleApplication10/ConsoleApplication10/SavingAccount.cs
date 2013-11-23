using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class SavingAccount : BasicClass
    {
        protected DateTime period;
        protected double interest_rate;
        public SavingAccount()
        { 
        }
        public SavingAccount(double rate, DateTime time, int log, int pin)
        {
            this.pin = pin;
            this.number = log;
            this.period = time;
            this.interest_rate = rate;
        }
        public override double getMoney(double count)
        {
            if (balance >= count)
            {
                if (DateTime.Now > period)
                {
                    balance -= count;
                    return count * (1d + interest_rate);
                }
                else
                {
                    balance -= count;
                    return count;
                }
            }
            return 0;
        }
        public override double checkBalance()
        {
            return balance;
        }
        public override void addMoney(double count)
        {
            base.addMoney(count);
        }
    }
}
