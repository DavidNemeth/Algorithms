using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Reinforcement
    {
        public void Entries()
        {

            int[] gameEntriesA = new int[5] { 1, 2, 3, 4, 5 };
            int[] gameEntriesB = gameEntriesA;
            gameEntriesB[4] = 550;
            Console.WriteLine(gameEntriesA[4]);
        }

        public bool IsMultiple(long n, long m)
        {
            return n % m == 0;
        }

        public bool IsEven(int i)
        {
            return (i & 1) == 0;
        }

        public int SumSquareAll(int n)
        {
            int x = 0;
            int total = 0;
            while (x <= n)
            {
                total += x * x;
                x++;
            }
            return total;
        }

        public int Vowels(string input)
        {
            int ret = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    ret++;
                }
            }
            return ret;
        }

        public string Punctuation(string input)
        {
            StringBuilder ret = new StringBuilder();
            foreach (var item in input)
            {
                if (char.IsLetterOrDigit(item) || char.IsWhiteSpace(item))
                {
                    ret.Append(item);
                }
            }
            return ret.ToString();
        }

        public int[] ReverseInts(int[] input)
        {
            int[] ret = new int[input.Length];
            int x = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ret[x] = input[i];
                x++;
            }
            return ret;
        }

        public int LargestInt(int[] input)
        {
            int ret = input[0];
            foreach (var item in input)
            {
                if (item > ret)
                {
                    ret = item;
                }
            }
            return ret;
        }

        public int Div(int x, int ret = 0)
        {
            if (x >= 2)
            {
                x = x / 2;
                return Div(x, ++ret);
            }
            return ret;
        }

        public bool Distinct(float[] values)
        {
            var hash = new HashSet<float>(values);
            return hash.Count == values.Length;
        }

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
    }
}
