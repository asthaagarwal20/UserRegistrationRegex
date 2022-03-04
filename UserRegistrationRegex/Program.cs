using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the FirstName");
            string firstName = Console.ReadLine();
            pattern.validateFirstName(firstName);
            Console.WriteLine("Enter the LastName");
            string lastName = Console.ReadLine();
            pattern.validateLastName(lastName);
            Console.WriteLine("Enter the MobileNo");
            string mobileNo = Console.ReadLine();
            pattern.validateMobileNo(mobileNo);
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            pattern.validatePassword(password);
        }
    }
}
