Imports System.Web
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ProjectVB

<TestClass()> Public Class AmountConvertTest

    <TestMethod()> Public Sub AmountConvert_ShouldReturnTrue_For2500()
        Assert.AreEqual(AmountConvertPage.ConvertAmountToWords(2500), "Two Thousand Five Hundred and 00/100 dollars")
    End Sub
End Class