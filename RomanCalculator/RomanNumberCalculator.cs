using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public static class RomanNumberCalculator
    {
        /// <summary>
        /// Calculate sum of two Roman Number
        /// </summary>
        /// <param name="firstRomanNumber"></param>
        /// <param name="secondRomanNumber"></param>
        /// <returns></returns>
        public static string CalculateSum(string firstRomanNumber, string secondRomanNumber)
        {
            bool validFirstNumeral = RomanUtility.ValidateRomanNumber(firstRomanNumber);
            bool validSecondNumeral = RomanUtility.ValidateRomanNumber(secondRomanNumber);

            if (validFirstNumeral && validSecondNumeral)
            {
                int firstInt = RomanUtility.RomanToInt(firstRomanNumber.ToUpper());
                int secondInt = RomanUtility.RomanToInt(secondRomanNumber.ToUpper());

                int sumDecimal = Addition(firstInt, secondInt);
                return RomanUtility.IntToRoman(sumDecimal);
            }
            return "INVALID";
        }
        /// <summary>
        /// Addition of integer number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
