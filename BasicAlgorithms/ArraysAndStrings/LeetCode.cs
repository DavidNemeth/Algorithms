using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public class LeetCode
    {
        //126
        public int SingleNumber(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item] += 1;
                }
            }
            int ret = 0;
            if (dict.ContainsValue(1))
            {
                ret = dict.FirstOrDefault(x => x.Value == 1).Key;
                return ret;
            }
            return 0;
        }
        //371
        public int AddShift(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            if (a == 0)
            {
                return b;
            }
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
        //292
        public bool CanWinNim(int n)
        {
            if (n == 1 || n == 2 || n == 3)
            {
                return true;
            }

            if (n % 4 != 0)
            {
                return true;
            }
            else return false;
        }
        //258
        public int AddDigitsRecursive(int num)
        {
            if (num < 10)
            {
                return num;
            }
            string nums = num.ToString();
            int numerOfDigits = 0;
            int ret = 0;
            foreach (var item in nums)
            {
                numerOfDigits++;
            }
            if (numerOfDigits > 1)
            {
                foreach (var item in nums)
                {
                    int temp = (int)char.GetNumericValue(item);
                    ret += temp;
                }
            }
            if (ret < 9)
            {
                return ret;
            }
            return AddDigitsRecursive(ret);
        }
        //258
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            string nums = num.ToString();
            int numberOfDigits = nums.Length;
            int ret = num;
            while (numberOfDigits > 1)
            {
                ret = 0;
                foreach (var item in nums)
                {
                    int temp = (int)char.GetNumericValue(item);
                    ret += temp;
                }
                numberOfDigits = ret.ToString().Length;
                nums = ret.ToString();
            }
            return ret;
        }
        //258 (1ms)
        public int addDigits(int num)
        {
            if (num == 0)
                return 0;
            int temp = num % 9;
            if (temp == 0)
                return 9;
            return temp;
        }
    }
}
