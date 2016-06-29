
using System;

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
    }
}
