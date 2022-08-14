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
    public class RomanNumberCalculatorTest
    {
        [TestMethod]
        public void Addition_Test_12_50_AssertThatItsTrue()
        {
            int result = RomanCalculator.RomanNumberCalculator.Addition(12, 50);
            Assert.AreEqual(62, result);
        }
        [TestMethod]
        public void CalculateSum_Test_MCLI_DXV_AssertThatItsMDCLXVI()
        {
            string result = RomanCalculator.RomanNumberCalculator.CalculateSum("MCLI", "DXV");
            Assert.AreEqual("MDCLXVI", result);
        }
        [TestMethod]
        public void CalculateSum_Test_IIX_I_AssertThatItsInvalid()
        {
            string result = RomanCalculator.RomanNumberCalculator.CalculateSum("IIX", "I");
            Assert.AreEqual("INVALID", result);
        }
    }
}
