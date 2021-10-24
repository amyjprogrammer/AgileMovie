using AgileMovie.Data;
using AgileMovie.Models;
using AgileMovie.Services;
using Microsoft.AspNet.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Http;
using System.Web.Mvc;


namespace AgileMovie.Tests
{
    //[TestClass]
   /* public class CustomerServiceTests
    {
        private readonly Guid _userId;

        [TestMethod]
        public void CreateCustomer_ShouldGetCorrectBoolean()
        {
            var date = new DateTime(2000, 03, 24);
            var content = new Customer()
            {
                OwnerId = _userId,
                FirstName = "Joe",
                LastName = "Doe",
                Email = "test@test.com",
                BirthDate = date,
            };

            var customerInfo = new CustomerCreate()
            {
                FirstName = content.FirstName,
                LastName = content.LastName,
                Email = content.Email,
                Birthdate = content.BirthDate
            };

            var customer = new CustomerService(_userId);

            bool success = customer.CreateCustomer(customerInfo);

            Assert.IsTrue(success);


           *//* var date = new DateTime(2000, 03, 24);

            var controller = new Customer()
            {
                OwnerId = _userId,
                FirstName = "Joe",
                LastName = "Doe",
                Email = "test@test.com",
                BirthDate = date
            };

            var ctx = new ApplicationDbContext();
            ctx.Customers.Add(controller);
            bool test = ctx.SaveChanges() == 1;

            var customerInfo = new CustomerCreate()
            {
                FirstName = controller.FirstName,
                LastName = controller.LastName,
                Email = controller.Email,
                Birthdate = controller.BirthDate
            };

            var customer = new CustomerService(_userId);
            bool success = customer.CreateCustomer(customerInfo);

            Assert.AreEqual(success, test);*//*
        }
    }*/
}
