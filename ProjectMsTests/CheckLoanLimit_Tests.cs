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

    public class CheckLoanLimit_Tests
    {
        [TestMethod]
        public void CheckIfAmountIsConvertedToSEKfromOtherCurrency()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount(2345, "Sparkonto", 2000, "USD", 10.42m);
            cus.BankAccounts.Add(1244, konto);
            //Act
            cus.CheckLoanLimit();
            var expected = 2000 * 10.42m;

            //Assert
            Assert.AreEqual(expected, cus.sum);
        }
        [TestMethod]
        public void CheckiIfAmountIsSEK()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount(2345, "Sparkonto", 2000, "SEK", 1m);
            cus.BankAccounts.Add(1244, konto);
            //Act
            cus.CheckLoanLimit();
            var expected = 2000m;

            //Assert
            Assert.AreEqual(expected, cus.sum);
        }
        [TestMethod]
        public void CheckLoanLimit_Should_Return_CorrectMaxLoanAmount_BeforeBeingMultiplied()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount(2345, "Sparkonto", 20000, "SEK", 1m);
            LoanAccount loan = new LoanAccount(123, "Bolån", -1000m, "SEK", 1m);
            cus.BankAccounts.Add(1244, konto);
            cus.LoanAccounts.Add(12444, loan);
            //Act
            cus.CheckLoanLimit();
            var expected = 20000m - (1000m / 5);

            //Assert
            Assert.AreEqual(expected, cus.sum);
        }
        [TestMethod]
        public void CheckLoanLimit_Should_Return_CorrectMaxLoanAmount()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount(2345, "Sparkonto", 20000, "SEK", 1m);
            LoanAccount loan = new LoanAccount(123, "Bolån", -1000m, "SEK", 1m);
            cus.BankAccounts.Add(1244, konto);
            cus.LoanAccounts.Add(12444, loan);
            //Act
            var res = cus.CheckLoanLimit();
            var expected = (20000m - (1000m / 5)) * 5;

            //Assert
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void CheckLoanLimit_Should_Return_CorrectMaxLoanAmount_IfThereAreNoPreviousLoans()
        {
            //Arrange
            Customer cus = new Customer("dan", "dan");
            BankAccount konto = new BankAccount(2345, "Sparkonto", 2000, "SEK", 1m);
            cus.BankAccounts.Add(1244, konto);
            //Act
            var res = cus.CheckLoanLimit();
            var expected = 2000 * 5;
            //    return sum * 5;

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
