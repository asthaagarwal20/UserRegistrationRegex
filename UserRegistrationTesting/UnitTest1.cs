using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationRegex;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenWrongFirstName_ShouldReturnInvalidFirstName()
        {
            string expected = "FirstName is not Valid";
            string FirstName = "astha";
            Pattern pattern = new Pattern();
           string actual= pattern.validateFirstName(FirstName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongLastName_ShouldReturnInvalidLastName()
        {
            string expected = "LastName is not Valid";
            string LastName = "agarwal";
            Pattern pattern = new Pattern();
            string actual = pattern.validateLastName(LastName);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenWrongEmail_ShouldReturnInvalidEmail()
        {
            string expected = "Email is not Valid";
            string email = " abcyahoo.com";
            Pattern pattern = new Pattern();
            string actual = pattern.validateEmail(email);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenWrongMobileNo_ShouldReturnInvalidMobileNo()
        {
            string expected = "Mobile no is not Valid";
            string mobileNo = "1234567890";
            Pattern pattern = new Pattern();
            string actual = pattern.validateMobileNo(mobileNo);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnInvalidPassword()
        {
            string expected = "Password is not Valid";
            string password = "As1@#$rt5";
            Pattern pattern = new Pattern();
            string actual = pattern.validatePassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}