using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            string result = "";
            for (int i = 1; i < original.Length+1; i++)
            {
                result += original[original.Length - i];
            }
            return result;
        }
    }
}
