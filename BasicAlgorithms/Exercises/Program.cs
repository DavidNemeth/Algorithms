using System;
using Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Reinforcement rein = new Reinforcement();
            Console.WriteLine(rein.SumSquareAll(6));
            Flower rose = new Flower(1, Flower.Flowers.Rose);
            rose.Quantity = 3;
            Console.WriteLine("flower name: {0} \nquantity: {1} \nTotal Price: {2}", rose._Flower, rose.Quantity, rose.Price);
            Console.WriteLine();

            CreditCard[] wallet = new CreditCard[3]
            {
                new CreditCard("Németh Dávid","Cib Bank","0012 1204 1241 6222", 6000, 3000),
                new CreditCard("Németh Dávid","Erste Bank","2512 7123 6111 2223", 12000, 1000),
                new CreditCard("Németh Dávid","Budapest Bank","7623 2152 6666 2312", 3000, -500)
            };
            wallet[0].Charge(3000);
            wallet[0].Charge(1000);
            wallet[0].Limit = 100;
            wallet[2].PrintSummary();
            Console.WriteLine();
            Console.WriteLine(wallet[0].ToString());
            Reinforcement.BirthDayParadox(23);
        }        
    }
}

