
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArraysAndStrings
{
    public static class HelperSolutions
    {
        public static string GenerateSlug(this string input)
        {
            string output = input.Trim().ToLower();
            string[] sArr = new string[output.Length];

            for (int i = 0; i < output.Length; i++)
            {
                if (char.IsLetter(output[i]))
                {
                    sArr[i] = output[i].ToString();
                }
                else
                {
                    sArr[i] = "%20";
                }
            }
            output = string.Join("", sArr);
            return output;
        }
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
        public static bool IsNullOrEmpty(this string s)
        {
            return String.IsNullOrEmpty(s);
        }
        public static bool IsNull(this object input)
        {
            return input == null;
        }
        public static bool Match<T>(this T value, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(value.ToString());
        }
        public static int ToInt32(this string value)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(value))
                int.TryParse(value, out result);

            return result;
        }
    }
}
