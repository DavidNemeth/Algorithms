using BinaryTree;
using System;
using MergeSorting;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[6] { 1, 3, 5, 2, 7, 6 };
            IComparable[] mSort = new IComparable[10] { 5, 2, 7, 3, 21, 6, 52, 62, 2, 6 };
            Solutions sol = new Solutions();
            //Console.WriteLine(sol.IsUnique("asdfghjklqwertzuiopőú"));
            //Console.WriteLine(sol.PermutationCount("123456789100asdfghhjxyacyqqwe"));
            //Console.WriteLine("Mr John Smith     ".GenerateSlug());
            //Console.WriteLine(sol.IsPalindromePermutation("Tact Coa "));
            //Console.WriteLine(sol.Distance("pale", "ple"));
            //Console.WriteLine(sol.StringCompression("aabcccccaaa"));
            //Console.WriteLine(sol.Inversion(iArr));
            Console.WriteLine(sol.Inversion(iArr));
        }
    }
}
