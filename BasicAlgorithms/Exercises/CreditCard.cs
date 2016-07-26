using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class CreditCard
    {
        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private string bank;
        public string Bank
        {
            get { return bank; }
            set { bank = value; }
        }
        private string account;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        private int limit;
        public int Limit
        {
            get { return limit; }
            set
            {
                if (value < balance)
                {
                    Console.WriteLine("Can not set lower limit than current balance");
                }
                else
                {
                    limit = value;
                }                
            }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CreditCard(string customer, string bank, string account, int limit, double balance)
        {
            this.customer = customer;
            this.bank = bank;
            this.account = account;
            this.limit = limit;
            this.balance = balance;
        }

        public bool Charge(double amount)
        {
            if (amount + balance > limit)
            {
                Console.WriteLine("Charging of {0} account failed due to limit", this.account);
                return false;
            }
            balance += amount;
            return true;
        }

        public bool Payment(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Payment of {0} account failed, insufficient balance", account);
                return false;
            }
            balance -= amount;
            return true;
        }

        public void PrintSummary()
        {
            Console.WriteLine("Customer: {0}", Customer);
            Console.WriteLine("Bank: {0}", Bank);
            Console.WriteLine("Account: {0}", Account);
            Console.WriteLine("Limit: {0}", Limit);
            Console.WriteLine("Balance: {0}", Balance);
        }

        public override string ToString()
        {
            return Customer.ToString() +"\n"+ Bank.ToString() + "\n" + Account.ToString() 
                + "\n" + Limit.ToString() + "\n" + Balance.ToString();
        }
    }
}
