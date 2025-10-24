using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersNET;

namespace ProgrammersNET.Tests
{
    [TestClass]
    public class PalindromeCheckTest
    {
        [TestMethod]
        public void PalindromeCheck_ShouldReturnTrue_ForPalindromeNumber()
        {
            Assert.IsTrue(PalindromeCheckPage.IsPalindrome(121));
        }

        [TestMethod]
        public void PalindromeCheck_ShouldReturnFalse_ForNonPalindrome()
        {
            Assert.IsFalse(PalindromeCheckPage.IsPalindrome(123));
        }

        [TestMethod]
        public void PalindromeCheck_ShouldReturnTrue_ForSingleDigit()
        {
            Assert.IsTrue(PalindromeCheckPage.IsPalindrome(5));
        }
    }
}
