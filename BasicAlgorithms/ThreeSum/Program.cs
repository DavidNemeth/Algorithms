using System;
using System.Diagnostics;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randy = new Random();
            int[] inputs = new int[2000];
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = randy.Next(-50, 50);
            }
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ThreeSumCountN3(inputs);
            Console.WriteLine(timer.Elapsed.ToString("mm\\:ss\\.ff"));
            timer.Stop();
        }
        //O(n3)
        public static int ThreeSumCountN3(int[] input)
        {
            int n = input.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (input[i] + input[j] + input[k] == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
