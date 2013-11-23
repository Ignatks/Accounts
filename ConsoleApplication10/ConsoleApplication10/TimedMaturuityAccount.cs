using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class TimedMaturuityAccount : SavingAccount
    {
        public TimedMaturuityAccount(DateTime time, double rate,int log, int pin)
        {
            this.pin = pin;
            this.number = log;
            this.interest_rate = rate;
            this.period = time;
        }
        public override void addMoney(double count)
        {
            base.addMoney(count);
        }
        public override double checkBalance()
        {
            return balance;
        }
        public override double getMoney(double count)
        {
            if (DateTime.Now < this.period)
            {
                if (balance >= count)
                {
                    balance -= count;
                    return count;
                }
            }
            else
            {
                if (balance >= count * (1d + interest_rate))
                {
                    balance -= count * (1d + interest_rate);
                    return count * (1d + interest_rate);
                }
            }
            return 0d;
        }
    }
}
