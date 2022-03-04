using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Pattern
    {
        public string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public void validate(string firstName)
        {
            bool correct=Regex.IsMatch(firstName, FirstName);
            if (correct)
                Console.WriteLine("FirstName is correct");
            else
                Console.WriteLine("FirstName is not correct");
        }
    }
}
