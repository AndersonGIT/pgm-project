using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgrammersNET;

namespace ProgrammersNET.Tests
{
    [TestClass]
    public class ProgrammersNETTest
    {
        [TestMethod]
        public void AmountConvert_ShouldReturnTrue_For2500()
        {
            string stringResult = AmountConvertPage.ConvertAmountToWords(2500);
            Assert.AreEqual(stringResult, "Two Thousand Five Hundred and 00/100 dollars");
        }

        [TestMethod]
        public void PalindromeCheck_ShouldReturnTrue_ForPalindromeNumber()
        {
            Assert.IsTrue(PalindromeCheckPage.IsPalindrome(121));
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnFalse_ForNonPalindrome()
        {
            Assert.IsFalse(PalindromeCheckPage.IsPalindrome(123));
        }

        [TestMethod]
        public void IsPalindrome_ShouldReturnTrue_ForSingleDigit()
        {
            Assert.IsTrue(PalindromeCheckPage.IsPalindrome(5));
        }
    }
}
