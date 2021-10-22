using AgileMovie.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AgileMovie.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidFirstNameNoChar_ShouldThrowFormatException()
        {
            var test = new Customer();
            test.FirstName = "";//making sure it has at least one character
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]//tells the system to expect an exception
        public void InvalidFirstNameSymbol_ShouldThrowFormatException()
        {
            var test = new Customer();
            test.FirstName = "$#";//making sure it is letters
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]//tells the system to expect an exception
        public void InvalidLastNameNoChar_ShouldThrowFormatException()
        {
            var test = new Customer();
            test.LastName = "";//making sure it has at least one character
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void MyTestMethodInvalidLastNameSymbol_ShouldThrowFormatException()
        {
            var test = new Customer();
            test.LastName = "^&";//making sure it is letters
        }

        [TestMethod]
        public void FirstName_ReturnsCorrectString()
        {
            var content = new Customer();
            content.FirstName = "Jane";
            string expected = "Jane";
            string actual = content.FirstName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastName_ReturnsCorrectString()
        {
            var content = new Customer();
            content.LastName = "Doe";
            string expected = "Doe";
            string actual = content.LastName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullName_ReturnsCorrectName()
        {
            var content = new Customer();
            content.FirstName = "Jane";
            content.LastName = "Doe";
            string expected = "Jane Doe";
            string actual = content.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Email_ReturnsCorrectString()
        {
            var content = new Customer();
            content.Email = "jane.doe@gmail.com";
            string expected = "jane.doe@gmail.com";
            string actual = content.Email;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Birthdate_ReturnsCorrectDate()
        {
            var content = new Customer();
            content.BirthDate = new DateTime(1999, 03, 24);
            var expected = new DateTime(1999, 03, 24);
            var actual = content.BirthDate;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsBirthDate14DaysAway_ShouldReturnTrue()
        {
            var content = new Customer();
            var test = DateTime.Now;
            content.BirthDate = test.AddDays(14);
            Assert.IsTrue(content.IsBirthDate14DaysAway);
        }
    }
}
