using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgrammersNET;

namespace ProgrammersNET.Tests
{
    [TestClass]
    public class AmountConvertTest
    {
        [TestMethod]
        public void AmountConvert_ShouldReturnTrue_For2500()
        {
            string stringResult = AmountConvertPage.ConvertAmountToWords(2500);
            Assert.AreEqual(stringResult, "Two Thousand Five Hundred and 00/100 dollars");
        }       
    }
}
