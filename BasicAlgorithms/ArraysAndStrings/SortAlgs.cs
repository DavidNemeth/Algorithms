using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class SortAlgs
    {
        public void BubbleSort(int[] input)
        {
            for (int i = input.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        swapValues(ref input[j],ref input[j + 1]);
                    }
                }
            }
        }

        private void swapValues(ref int indexOne, ref int indexTwo)
        {
            int temp = indexOne;
            indexOne = indexTwo;
            indexTwo = temp;
        }
    }
}
