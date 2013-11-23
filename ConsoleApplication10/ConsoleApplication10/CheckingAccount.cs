using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class CheckingAccount : BasicClass
    {
        private int totaltransactions;
        private int mounthly_quota;
        private double per_transaction_fee;
        private double fee;
        public CheckingAccount(int totaltransactions, int mounthly_quota, double per_transaction_fee, double fee, int log, int pin)
        {
            this.pin = pin;
            this.number = log;
            this.totaltransactions = totaltransactions;
            this.mounthly_quota = mounthly_quota;
            this.per_transaction_fee = per_transaction_fee;
            this.fee = fee;
        }
        public override double checkBalance()
        {
            return base.checkBalance();
        }
        public override double getMoney(double count)
        {
            updateBalance();
            if (balance >= count)
            {
                balance -= count;
                return count;
            }
            return 0;

        }
        private void updateBalance()
        {
            totaltransactions++;
            if (mounthly_quota < totaltransactions)
            {
                fee += per_transaction_fee;
                balance -= per_transaction_fee;
            }
            
        }
    }
}
