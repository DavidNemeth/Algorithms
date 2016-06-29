using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("abasd"));
        }

        private static bool IsUnique(string input)
        {
            bool[] array = new bool[256];
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
    }
}
