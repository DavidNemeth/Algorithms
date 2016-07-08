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
    }
}
