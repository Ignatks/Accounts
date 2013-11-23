using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApplication10
{
    public class OverdraftAccount : BasicClass
    {
        TimeSpan period;
        double interestRate;
        Timer timer;
        public OverdraftAccount(TimeSpan time, double rate, int log, int pin)
        {
            this.pin = pin;
            this.number = log;
            timer = new Timer();
            timer.Elapsed += timer_Elapsed;
            timer.Interval = time.TotalMilliseconds;
            this.period = time;
            this.interestRate = rate;
            timer.AutoReset = false;//test
            timer.Start();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            updateBalance();
        }
        public override double getMoney(double count)
        {
            balance -= count;
            return count;
        }
        private void updateBalance()
        {
            if (balance < 0)
            {
                balance -= Math.Abs(balance) * interestRate;
            }
        }
    }
}
