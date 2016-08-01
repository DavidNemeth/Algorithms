using System;

namespace Exercises
{
    public class CibBank : CreditCard
    {
        private double apr;        
        private int chargecount;
        public double Apr
        {
            get { return apr; }
            set { apr = value; }
        }

        public CibBank(string customer, string bank, string account, double limit, double balance, double rate = 2)
            : base(customer, bank, account, limit, balance)
        {
            apr = rate;
            chargecount = 0;
            Chargetrashhold = 5;
        }

        //assessing monthly interest charges
        public void ProcessMonth()
        {
            if (Balance > 0)
            {
                double monthlyFactor = Math.Pow(1 + apr, 1.0 / 12);
                Console.WriteLine("\nMonthly factor: {0:F5}\n", monthlyFactor);
                Balance *= monthlyFactor;
                if (chargecount > Chargetrashhold)
                {
                    int temp = chargecount - Chargetrashhold;
                    Balance += temp;
                    Console.WriteLine("Processed an extra {0:C} for exceeding monthly charge limit.\n", temp);
                }
            }            
            chargecount = 0;
        }

        public override bool Charge(double price)
        {
            bool isSuccess = base.Charge(price);
            if (!isSuccess)
            {
                Console.WriteLine("You have been charged by {0:C}", 5);
                Balance += 5;
            }
            chargecount++;
            return isSuccess;
        }

    }
}
