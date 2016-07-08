using BinaryTree;
using System;
using MergeSorting;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[10] { 5, 2, 3, 6, 1, 3, 87, 1, 6, 0 };
            IComparable[] mSort = new IComparable[10] { 5, 2, 7, 3, 21, 6, 52, 62, 2, 6 };
            Solutions sol = new Solutions();
            SortAlgs sort = new SortAlgs();
            SearchAlgs search = new SearchAlgs();

            sort.BubbleSort(iArr);
            foreach (var item in iArr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
