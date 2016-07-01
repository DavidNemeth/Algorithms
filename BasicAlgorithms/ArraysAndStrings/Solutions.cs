using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool Permutation(string string1, string string2)
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
        private bool IsPalindrome(string input)
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

        //O(n^n)?
        private List<string> Permutations(string input)
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
    }
}
