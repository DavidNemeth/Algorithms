using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysAndStrings
{
    public class Solutions
    {
        //O(n)
        public bool IsUnique(string input)
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

        //O(n)
        public bool IsPalindromePermutation(string input)
        {
            int count = 0;
            string ret = "";

            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                {
                    ret += item;
                }
            }
            ret = ret.ToLower();

            var countkey = ret
                .GroupBy(x => x)
                .OrderBy(c => c.Key)
                .ToDictionary(grp => grp.Key, grp => grp.Count());
            foreach (var item in countkey)
            {
                if (item.Value % 2 == 1)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return false;
            }
            return true;
        }

        public bool Permutation(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                return false;
            }
            char[] first = input1.ToArray();
            char[] second = input2.ToArray();
            Array.Sort(first);
            Array.Sort(second);
            if (first.ToString() != second.ToString())
            {
                return false;
            }
            return true;
        }

        //O(n)
        public long PermutationCount(string input)
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

        //O(n)
        public bool IsPalindrome(string input)
        {
            string result = "";
            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                {
                    result += item;
                }
            }
            result = result.ToLower();
            string reverse = new string(result.ToCharArray().Reverse().ToArray());

            if (result == reverse)
            {
                return true;
            }
            return false;
        }

        //O(n!)
        public List<string> Permutations(string input)
        {
            var ret = new List<string>();
            if (input.Length == 1)
            {
                ret.Add(input);
            }
            else
            {
                foreach (var item in input)
                {
                    var perms = input.Remove(input.IndexOf(item), 1);
                    foreach (var perm in Permutations(perms))
                    {
                        ret.Add(item + perm);
                    }
                }
            }
            return ret;
        }

        public int Distance(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) return 0;

            int lengthA = a.Length;
            int lengthB = b.Length;
            var distances = new int[lengthA + 1, lengthB + 1];
            for (int i = 0; i <= lengthA; distances[i, 0] = i++) ;
            for (int j = 0; j <= lengthB; distances[0, j] = j++) ;

            for (int i = 1; i <= lengthA; i++)
                for (int j = 1; j <= lengthB; j++)
                {
                    int cost = b[j - 1] == a[i - 1] ? 0 : 1;
                    distances[i, j] = Math.Min
                        (
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                        );
                }
            return distances[lengthA, lengthB];
        }

        public string StringCompression(string input)
        {
            StringBuilder ret = new StringBuilder();

            char currentChar = input[0];
            ret.Append(currentChar);

            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                char nextchar = input[i];

                if (currentChar == nextchar)
                {
                    count++;
                }
                else
                {
                    ret.Append(count);
                    currentChar = nextchar;
                    count = 1;
                    ret.Append(currentChar);
                }
            }
            ret.Append(count);

            return ret.Length > input.Length ? input : ret.ToString();
        }

        //O(n*logn)
        public int Inversion(int[] arr)
        {
            if (arr.Count() < 2)
                return 0;

            int m = (arr.Length + 1) / 2;
            int[] left = arr.Take(m).ToArray();
            int[] right = arr.Skip(m).ToArray();

            return Inversion(left) + Inversion(right) + merge(arr, left, right);
        }

        private int merge(int[] arr, int[] left, int[] right)
        {
            int i = 0; int j = 0; int count = 0;
            while (i < left.Length || j < right.Length)
            {
                if (i == left.Length)
                {
                    arr[i + j] = right[j];
                    j++;
                }
                else if (j == right.Length)
                {
                    arr[i + j] = left[i];
                    i++;
                }
                else if (left[i] <= right[j])
                {
                    arr[i + j] = left[i];
                    i++;
                }
                else
                {
                    arr[i + j] = right[j];
                    count += left.Length - i;
                    j++;
                }
            }
            return count;
        }
    }
}
