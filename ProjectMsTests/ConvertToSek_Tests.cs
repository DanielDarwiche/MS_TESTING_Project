using KiwiBankomaten;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMsTests
{
    [TestClass]
    public class ConvertToSek_Tests
    {
        [TestMethod]
        public void ConvertToSEK_FROM_ValidCurrency_Should_Return_AmountInSEK()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");// USD is valid => returns SEK amount
            BankAccount konto = new BankAccount(2345, "Sparkonto", 2000, "USD", 10.42m);
            //Act
            var res = cus.ConvertToSek(konto);
            var expected = 2000 * 10.42m;
            //Assert
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void ConvertToSEK_FROM_InvalidCurrency_Should_Return_0()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");// BLA is invalid => returns 0
            BankAccount konto2 = new BankAccount(2345, "Sparkonto", 2000, "BLA", 10.42m);
            //Act
            var res = cus.ConvertToSek(konto2);
            var expected = 0;
            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
