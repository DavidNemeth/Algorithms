using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        //initalization (i=0; i<inputArray.Length), maintenance (i++), termination (return i)
        static IEnumerable<int> IndexOf(int[] inputArray, int targetValue)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == targetValue)
                {
                    yield return i;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 1, 2, 3, 6, 89, 9, 12, 23, 68, 1, 2, 4, 2 };
            foreach (var item in IndexOf(arr, 3))
            {
                Console.WriteLine(item);
            }
        }
    }
}
