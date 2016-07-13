using BinaryTree;
using System;
using MergeSorting;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[9] { 6, 2, 5, 2, 6, 7, 7, 1, 1 };
            IComparable[] mSort = new IComparable[10] { 5, 2, 7, 3, 21, 6, 52, 62, 2, 6 };
            Solutions sol = new Solutions();
            LeetCode leet = new LeetCode();
            SortAlgs sort = new SortAlgs();
            SearchAlgs search = new SearchAlgs();
            string kat = "kat".Reverse();
            int i = 3;
            if (i.Match("[1-5]"))
            {
                Console.WriteLine(kat);
            }
            Console.WriteLine(leet.SingleNumber(iArr));
        }
    }
}
