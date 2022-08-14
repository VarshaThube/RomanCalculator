using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberCalculatorTests
{
    [TestClass]
    public class RomanUtilityTests
    {
        [TestMethod]
        public void ValidateRomanNumber_Test_MCLI_AssertThatItsTrue()
        {
            bool result = RomanUtility.ValidateRomanNumber("MCLI");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateRomanNumber_Test_IIX_AssertThatItsFalse()
        {
            bool result = RomanUtility.ValidateRomanNumber("IIX");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void RomanToInt_Test_MCLI_AssertThatIts1151()
        {
            int result = RomanUtility.RomanToInt("MCLI");
            Assert.AreEqual(result, 1151);
        }
        [TestMethod]
        public void IntToRoman_Test_1151_AssertThatItsMCLI()
        {
            string result = RomanUtility.IntToRoman(1151);
            Assert.AreEqual(result, "MCLI");
        }
    }
}
