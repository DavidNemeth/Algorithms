using System;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Solutions sol = new Solutions();
            //Console.WriteLine(sol.IsUnique("asdfghjklqwertzuiopőú"));
            //Console.WriteLine(sol.PermutationCount("123456789100asdfghhjxyacyqqwe"));
            //Console.WriteLine("Mr John Smith     ".GenerateSlug());
            Console.WriteLine(sol.IsPalindromePermutation("Tact Coa "));
        }
    }
}
