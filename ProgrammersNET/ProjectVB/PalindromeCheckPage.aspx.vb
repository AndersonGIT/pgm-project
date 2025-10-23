Imports System.Globalization
Imports System
Imports System.Text
Imports System.Web.Services

Public Class PalindromeCheckPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    Public Shared Function IsPalindrome(number As Integer) As Boolean
        If number < 0 Then
            Return False
        End If

        Dim text As String = number.ToString()
        Dim reversed As Char() = text.ToCharArray()
        Array.Reverse(reversed)

        Return text = New String(reversed)
    End Function
End Class