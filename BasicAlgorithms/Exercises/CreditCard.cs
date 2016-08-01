using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class CreditCard
    {
        public string Customer { get; set; }
        public int Chargetrashhold { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public double Balance { get; set; }
        public double Limit { get; set; }

        public CreditCard(string customer, string bank, string account, double limit, double balance)
        {
            Customer = customer;
            Bank = bank;
            Account = account;
            Limit = limit;
            Balance = balance;
        }

        public virtual bool Charge(double amount)
        {
            if (amount + Balance > Limit)
            {
                Console.WriteLine("Charging of {0} account failed due to limit", this.Account);
                return false;
            }
            Balance += amount;
            Console.WriteLine("Charged {0:C} from account {1}", amount, this.Account);
            return true;
        }

        public bool Payment(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Can not process negative payment\n");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Payment of {0} account failed, insufficient balance", Account);
                return false;
            }
            Balance -= amount;
            return true;
        }

        public void PrintSummary()
        {
            Console.WriteLine("Customer: {0}", Customer);
            Console.WriteLine("Bank: {0}", Bank);
            Console.WriteLine("Account: {0}", Account);
            Console.WriteLine("Limit: {0:C}", Limit);
            Console.WriteLine("Balance: {0:C}", Balance);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return Customer.ToString() + "\n" + Bank.ToString() + "\n" + Account.ToString()
                + "\n" + Limit.ToString("C") + "/" + Balance.ToString("C") + "\n";
        }
    }
}
