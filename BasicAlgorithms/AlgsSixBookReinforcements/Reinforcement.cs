using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgsSixBookReinforcements
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

        public static void MistakesWereMade()
        {
            string typo = "I will never do this again";
            Random randy = new Random();
            string[] punishment = new string[100];
            for (int i = 0; i < punishment.Length; i++)
            {
                if (i % 15 == 0)
                {
                    string temp = typo.Remove(randy.Next(typo.Length), 1);
                    punishment[i] = temp;
                }
                else
                {
                    punishment[i] = typo;
                }
            }
            punishment.Shuffle();
            int count = punishment.Distinct().Count();
            foreach (var item in punishment)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(count + " mistakes");
        }

        public static void BirthDayParadox(int numberOfPeople)
        {
            int count = 0;
            Random randy = new Random();
            int testQuantity = 123456;
            for (int x = 0; x < testQuantity; x++)
            {
                bool[] bdays = new bool[365];
                for (int i = 1; i <= numberOfPeople; i++)
                {
                    int temp = randy.Next(365);
                    if (bdays[temp])
                    {
                        count++;
                        break;
                    }
                    else
                    {
                        bdays[temp] = true;
                    }
                }
            }
            double result = (double)count / (double)testQuantity;
            Console.WriteLine("{0:P3}", result);
        }

        public int WordCount(string input, string searchterm)
        {
            string[] source = input.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchterm.ToLowerInvariant()
                             select word;
            return matchQuery.Count();
        }

        public Dictionary<string, int> EachWordCount(string input)
        {
            var result = input.Split(new[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(w => w)
                 .Select(g => new { g.Key, count = g.Count() })
                 .ToDictionary(g => g.Key, g => g.count);

            return result;
        }
    }
}
