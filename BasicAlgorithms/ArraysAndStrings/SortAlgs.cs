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
                        swapValues(ref input[j], ref input[j + 1]);
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

        public void SelectionSort(int[] input)
        {
            for (int x = 0; x < input.Length; x++)
            {
                int minimum = x;

                for (int y = x; y < input.Length; y++)
                {
                    if (input[minimum] > input[y])
                    {
                        minimum = y;
                    }
                }
                swapValues(ref input[x], ref input[minimum]);
            }
        }

        public void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int j = i;
                int current = data[i];
                while ((j > 0) && (data[j - 1] > current))
                {
                    data[j] = data[j - 1];
                    j--;
                }
                data[j] = current;
            }
        }
    }
}