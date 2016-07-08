using System;

namespace ArraysAndStrings
{
    public class SearchAlgs
    {
        public void LinearSearch(int[] input, int value)
        {
            int index = 0;
            bool found = false;

            foreach (var item in input)
            {
                if (item == value)
                {
                    index = Array.IndexOf(input, item);
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("found value of {0}, at the index: {1}", value, index);
            }
            else
            {
                Console.WriteLine("value {0} not found in the input array", value);
            }
        }

        public void BinarySearch(int[] input, int value)
        {
            int lowIndex = 0;
            int highIndex = input.Length -1;

            while (lowIndex <= highIndex)
            {
                int middleIndex = (highIndex + lowIndex) / 2;

                if (input[middleIndex] < value)
                {
                    lowIndex = middleIndex + 1;
                }
                else if (input[middleIndex] > value)
                {
                    highIndex = middleIndex - 1;
                }
                if (input[middleIndex] == value)
                {
                    Console.WriteLine("Found {0} at {1} index", value, middleIndex);
                    lowIndex = highIndex + 1;
                }                
            }
        }
    }
}
