using System;

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
            CreditCard.PrintSummary(wallet[1]);
            Console.WriteLine();
            int[] rev = rein.ReverseInts(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            foreach (var item in rev)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(rein.LargestInt(rev));
            Console.WriteLine();
            Console.WriteLine(rein.Div(2000));
            Console.WriteLine();

            float[] fArr = new float[10] { 0, 1, 2F, 3, 4.23F, 2.32F, 6, 2.1F, 8, 4.23F };
            Console.WriteLine(rein.Distinct(fArr));
        }
    }
}

