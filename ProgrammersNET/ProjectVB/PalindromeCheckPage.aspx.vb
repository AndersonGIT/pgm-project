Imports System.Globalization
Imports System
Imports System.Text
Imports System.Web.Services

Public Class PalindromeCheckPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    Public Shared Function IsPalindrome(input As String) As Boolean
        'If Number < 0 Then
        '    Return False
        'End If

        'Dim text As String = Number.ToString()
        Dim reversed As Char() = input.Replace(" ", "").ToLower().ToCharArray()
        Array.Reverse(reversed)

        Return input.Replace(" ", "").ToLower() = New String(reversed).ToLower()
    End Function
End Class