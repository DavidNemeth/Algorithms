using System;

namespace MergeSorting
{
    public class MergeSort
    {
        private static void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo;
            int j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hi)
                {
                    a[k] = aux[i++];
                }
                else if (aux[j].CompareTo(aux[i]) < 0)
                {
                    a[k] = aux[j++];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }
        }

        private static void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            if (hi <= lo)
            {
                return;
            }
            int mid = lo + (hi - lo) / 2;
            sort(a, aux, lo, mid);
            sort(a, aux, mid + 1, hi);
            merge(a, aux, lo, mid, hi);
        }

        public static void MSort(IComparable[] a)
        {
            var aux = new IComparable[a.Length];
            sort(a, aux, 0, a.Length - 1);
        }
    }
}
