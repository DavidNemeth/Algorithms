using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class CibBank : CreditCard
    {
        private double apr;
        public double Apr
        {
            get { return apr; }
            set { apr = value; }
        }

        public CibBank(string customer, string bank, string account, double limit, double balance, double rate = 5)
            : base(customer, bank, account, limit, balance)
        {
            apr = rate;
        }

        //assessing monthly interest charges
        public void ProcessMonth()
        {
            if (Balance > 0)
            {
                double monthlyFactor = Math.Pow(1 + apr, 1.0 / 12);
                Balance *= monthlyFactor;
            }
        }

        public override bool Charge(double price)
        {
            bool isSuccess = base.Charge(price);
            if (!isSuccess)
            {
                Console.WriteLine("You have been charged by {0:C}", 5);
                Balance += 5;
            }
            return isSuccess;
        }

    }
}
