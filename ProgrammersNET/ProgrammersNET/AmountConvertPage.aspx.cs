using System;
using System.Globalization;
using System.Text;

namespace ProgrammersNET
{
    public partial class AmountConvertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                if (!string.IsNullOrWhiteSpace(amountValue.Value))
                {
                    if (Decimal.TryParse(amountValue.Value, out decimal amount))
                    {
                        txtResult.Value = ConvertAmountToWords(amount);
                    }
                }
                else
                {
                    txtResult.Value = "The input is not a valid number";
                }
        }

        static string ConvertAmountToWords(decimal amount)
        {
            long dollars = (long)Math.Floor(amount);
            int cents = (int)((amount - dollars) * 100);

            string dollarsText = NumberToWords(dollars);
            string centsText = cents.ToString("00");

            return $"{dollarsText} and {centsText}/100 dollars";
        }

        static string NumberToWords(long number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            StringBuilder words = new StringBuilder();

            string[] unitsMap = { "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine", "ten", "eleven",
                              "twelve", "thirteen", "fourteen", "fifteen",
                              "sixteen", "seventeen", "eighteen", "nineteen" };

            string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty",
                             "sixty", "seventy", "eighty", "ninety" };

            if ((number / 1_000_000_000) > 0)
            {
                words.Append(NumberToWords(number / 1_000_000_000) + " billion ");
                number %= 1_000_000_000;
            }

            if ((number / 1_000_000) > 0)
            {
                words.Append(NumberToWords(number / 1_000_000) + " million ");
                number %= 1_000_000;
            }

            if ((number / 1_000) > 0)
            {
                words.Append(NumberToWords(number / 1_000) + " thousand ");
                number %= 1_000;
            }

            if ((number / 100) > 0)
            {
                words.Append(NumberToWords(number / 100) + " hundred ");
                number %= 100;
            }

            if (number > 0)
            {
                if (words.Length > 0)
                    words.Append(" ");

                if (number < 20)
                    words.Append(unitsMap[number]);
                else
                {
                    words.Append(tensMap[number / 10]);
                    if ((number % 10) > 0)
                        words.Append("-" + unitsMap[number % 10]);
                }
            }

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words.ToString().Trim());
        }
    }
}