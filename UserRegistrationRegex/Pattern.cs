using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Pattern
    {
        public string FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public string LastName = "^[A-Z]{1}[a-z]{2,}$";
        public string Email= " ^[A - Z0 - 9a - z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public string MobileNo = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        public string Password = "^(?=.*[A-Z])[a-zA-Z0-9!@#$%^&*]{8,}$";
        public string validateFirstName(string firstName)
        {
            bool correct=Regex.IsMatch(firstName, FirstName);
            if (correct)
                return "FirstName is Valid";
            else
                return "FirstName is not Valid";
        }
        public string validateLastName(string lastName)
        {
            bool correct = Regex.IsMatch(lastName, LastName);
            if (correct)
                return "LastName is Valid";
            else
                return "LastName is not Valid";
        }
        public string validateEmail(string email)
        {
            bool correct = Regex.IsMatch(email, Email);
            if (correct)
                return "Email is Valid";
            else
                return "Email is not Valid";
        }
        public string validateMobileNo(string mobileNo)
        {
            bool correct = Regex.IsMatch(mobileNo,MobileNo);
            if (correct)
                return "Mobile no is Valid";
            else
                return "Mobile no is not Valid";
        }
        public string validatePassword(string password)
        {
            bool correct = Regex.IsMatch(password, Password);
            if (correct)
                return "Password is Valid";
            else
                return "Password is not Valid";
        }
    }
}
