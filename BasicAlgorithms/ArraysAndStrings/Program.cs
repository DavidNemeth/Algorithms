using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions sol = new Solutions();

            Console.WriteLine(sol.IsUnique("asdfghjklqwertzuiopőú"));
            Console.WriteLine(sol.PermutationCount("123456789100asdfghhjxyacyqqwe"));
            Console.WriteLine("Mr John Smith     ".GenerateSlug());
        }
    }
}
