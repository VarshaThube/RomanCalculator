using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public static class RomanUtility
    {
        /// <summary>
        /// Validate Roman Number
        /// </summary>
        /// <param name="romanNumber"></param>
        /// <returns></returns>
        public static bool ValidateRomanNumber(string romanNumber)
        {
            string pattern = "^(?=[MDCLXVI])M*(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$";
            if (Regex.IsMatch(romanNumber, pattern, RegexOptions.IgnoreCase))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Convert Roman to Int number
        /// </summary>
        /// <param name="romanNumber"></param>
        /// <returns></returns>
        public static int RomanToInt(string romanNumber)
        {
            var romanNumerals = new Dictionary<char, int> {
                {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
            };
            var integerNum = 0;
            for (int index = 0; index < romanNumber.Length; index++)
            {
                var value = romanNumerals[romanNumber[index]];
                if ((index + 1 < romanNumber.Length) && (romanNumerals[romanNumber[index + 1]] > value)) //Higher next number
                    integerNum -= value;
                else //Lower next number
                    integerNum += value;
            }
            return integerNum;
        }
        /// <summary>
        /// Convert Int to Roman
        /// </summary>
        /// <param name="intNumber"></param>
        /// <returns></returns>
        public static string IntToRoman(int intNumber)
        {
            //if (intNumber < 0)
            List<int> decimalNumbers = new List<int>() { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            List<string> romanNumbers = new List<string>() { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int count = decimalNumbers.Count - 1;
            var romanNum = "";
            while (intNumber != 0)
            {
                if (decimalNumbers[count] <= intNumber)
                {
                    romanNum += romanNumbers[count];
                    intNumber -= decimalNumbers[count];
                }
                else
                {
                    count--;
                }
            }
            return romanNum;
        }
    }
}
