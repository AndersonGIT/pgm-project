using System;
using System.Web.Services;

namespace ProgrammersNET
{
    public partial class PalindromeCheckPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                if (!string.IsNullOrWhiteSpace(valueInput.Value))
                {
                    if (int.TryParse(valueInput.Value, out int value))
                    {
                        bool isPalindrome = IsPalindrome(value);

                        if (isPalindrome)
                            txtResult.Value = $"{value} is a palindrome!";
                        else
                            txtResult.Value = $"{value} is NOT a palindrome!";
                    }
                    else
                    {
                        txtResult.Value = "The input is not valid number.";
                    }

                }
        }

        [WebMethod]
        public static bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;

            string text = number.ToString();
            char[] reversed = text.ToCharArray();
            Array.Reverse(reversed);

            return text == new string(reversed);
        }
    }
}