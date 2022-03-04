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
        public string LastName = "^[A-Z]{1}[a-z]{2,}$";
        public string MobileNo = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        public void validateFirstName(string firstName)
        {
            bool correct=Regex.IsMatch(firstName, FirstName);
            if (correct)
                Console.WriteLine("FirstName is correct");
            else
                Console.WriteLine("FirstName is not correct");
        }
        public void validateLastName(string lastName)
        {
            bool correct = Regex.IsMatch(lastName, LastName);
            if (correct)
                Console.WriteLine("LastName is correct");
            else
                Console.WriteLine("LastName is not correct");
        }
        public void validateMobileNo(string mobileNo)
        {
            bool correct = Regex.IsMatch(mobileNo,MobileNo);
            if (correct)
                Console.WriteLine("correct");
            else
                Console.WriteLine("not correct");
        }
    }
}
