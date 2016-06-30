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

        //O(n^2)
        public bool IsPalindromePermutation(string input)
        {
            bool unevenFound = false;
            char uneven = ' ';

            int count = 0;

            //Remove whitespace from the string.
            string ret = "";
            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item))
                {
                    ret += item;
                }
            }
            ret = ret.ToLower();
            // Check each letter to see if there's an even number of it.
            for (int i = 0; i < ret.Length; i++)
            {
                count = 0;
                for (int j = 0; j < ret.Length; j++)
                {
                    if (ret[j] == ret[i])
                    {
                        count++;
                    }
                }
                // If there was an odd number of those entries
                // and an uneven is already found, then a palindrome
                // is impossible, so return false.
                if (count % 2 == 1)
                {
                    if (unevenFound == true && uneven != ret[i])
                    {
                        return false;
                    }
                    else
                    {
                        unevenFound = true;
                        uneven = ret[i];   
                    }
                }
            }
            // If we made it all the way through that loop without returning false, then
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
