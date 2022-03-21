using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public static class AToI
    {
        public static int MyAtoi(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            int sign = 1, i = 0, result = 0;
            int maxDiv10 = int.MaxValue / 10;
            int nextDigit;

            while (s[i] == ' ') i++;

            if(s[i] =='+' || s[i] == '-')
            {
                sign = (s[i] == '-') ? -1 : 1;
                i++;
            }

            var LastDigitMax = (sign == 1) ? 7 : 8;

            while(i < s.Length && char.IsDigit(s[i]))
            {
                nextDigit = (int)(s[i++] - '0');

                if (result > maxDiv10 || result == maxDiv10 && nextDigit > LastDigitMax) 
                {
                    return (sign == 1) ? int.MaxValue : int.MinValue;
                } 
                   
                result = result * 10 + nextDigit;
            }

            return result * sign;
        }
    }
}



//Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

//The algorithm for myAtoi(string s) is as follows:

//Read in and ignore any leading whitespace.
//Check if the next character (if not already at the end of the string) is '-' or '+'.Read this character in if it is either.This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
//Read in next the characters until the next non-digit character or the end of the input is reached. The rest of the string is ignored.
//Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
//If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
//Return the integer as the final result.