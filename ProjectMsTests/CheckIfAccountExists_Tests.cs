using FluentAssertions;
using KiwiBankomaten;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DescriptionAttribute = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace ProjectMsTests
{
    [TestClass]
    public class CheckIfAccountExists_Tests
    {
        [TestMethod]
        public void CheckIfAccountExists_W_RightAccount_Should_Be_Found()
        {
            //Arrange
            DataBase db = new DataBase();
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount();
            //act
            bool res = cus.CheckIfAccountExists(40448655);
            //Assert
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void CheckIfAccountExists_W_WrongAccount_ShouldNOT_Be_Found()
        {
            //Arrange
            DataBase db = new DataBase();
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount();
            //act
            bool res = cus.CheckIfAccountExists(40655);
            //Assert
            Assert.IsFalse(res);
        }
    }
}
