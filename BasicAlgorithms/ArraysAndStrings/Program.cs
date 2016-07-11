using BinaryTree;
using System;
using MergeSorting;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[10] { 4, 2, 5, 3, 6, 7, 8, 9, 0, 1 };
            IComparable[] mSort = new IComparable[10] { 5, 2, 7, 3, 21, 6, 52, 62, 2, 6 };
            Solutions sol = new Solutions();
            SortAlgs sort = new SortAlgs();
            SearchAlgs search = new SearchAlgs();
            foreach (var item in sol.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
