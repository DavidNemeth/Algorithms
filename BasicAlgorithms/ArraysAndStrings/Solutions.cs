using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class Solutions
    {
        public static bool IsUnique(string input)
        {
            bool[] array = new bool[512];
            foreach (var item in input)
            {
                if (array[(int)item])
                {
                    return false;
                }
                else
                {
                    array[(int)item] = true;
                }
            }
            return true;
        }

        public static bool Permutation(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }
            char[] first = string1.ToArray();
            char[] second = string2.ToArray();
            Array.Sort(first);
            Array.Sort(second);
            if (first.ToString() != second.ToString())
            {
                return false;
            }
            return true;
        }

        public static long PermutationCount(string input)
        {
            int count = 0;
            bool[] barray = new bool[512];
            foreach (var item in input)
            {
                barray[item] = true;
            }
            foreach (var item in barray)
            {
                if (item)
                {
                    count++;
                }
            }
            long result = count;
            for (int i = 1; i < count; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
