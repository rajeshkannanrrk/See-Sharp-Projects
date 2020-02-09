using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatPhoneNumber("5139812523"));
            Console.WriteLine(FormatPhoneNumber("oh boy"));
            Console.WriteLine(FormatPhoneNumber("513981jennyjenny2523"));
            Console.WriteLine(FormatPhoneNumber("5139867530912523"));
        }
        static string FormatPhoneNumber(string digits)
        {
            string FormattedPhoneNumber = "";
            FormattedPhoneNumber = PhoneNumber(digits);

            return FormattedPhoneNumber;
        }
        static string PhoneNumber(string inputText)
        {
            string numbersOnly = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                string oneLetter = inputText.Substring(i, 1);
                if ("0123456789".IndexOf(oneLetter) > -1)
                {
                    numbersOnly += oneLetter;
                }
                if (numbersOnly.Length == 10)
                {
                    numbersOnly = "{" + numbersOnly.Substring(0, 3) + ")"
                        + numbersOnly.Substring(3, 3)
                        + "-" + numbersOnly.Substring(6);
                }
            }
            return numbersOnly;
        }
    }
}
