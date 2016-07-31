using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard[] wallet = new CreditCard[3]
            {
                new CibBank("Németh Dávid","Cib Bank","0012 1204 1241 6222", 6000, 3000),
                new CreditCard("Németh Dávid","Erste Bank","2512 7123 6111 2223", 12000, 1000),
                new CreditCard("Németh Dávid","Budapest Bank","7623 2152 6666 2312", 3000, -500)
            };
            wallet[0].PrintSummary();            
            wallet[0].Charge(6000);
            Console.WriteLine();
            Console.WriteLine(wallet[0].ToString());
            wallet[0].PrintSummary();
        }
    }
}

