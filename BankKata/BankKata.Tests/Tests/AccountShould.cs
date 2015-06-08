using System;
using System.Collections.Generic;
using NUnit.Framework;
using Should;
using Moq;

namespace BankKata.Tests
{
    [TestFixture]
    public class AccountShould
    {
        [Test]
        public void Store_Deposit_Transactions()
        {
            var console = new Console();
            var transactionRepository = new Mock<ITransactionRepository>();

            var account = new Account(transactionRepository.Object, console);

            account.Deposit(1000);

            transactionRepository.Verify(ts => ts.Store(It.IsAny<Transaction>()),
                Times.Once);
        }

        [Test]
        public void Store_Withdraw_Transactions()
        {
            var console = new Console();
            var transactionRepository = new Mock<ITransactionRepository>();

            var account = new Account(transactionRepository.Object, console);

            account.Withdrawal(1000);

            transactionRepository.Verify(ts => ts.Store(It.IsAny<Transaction>()),
                Times.Once);
        }


        [Test]
        public void Print_Transactions_And_Balance()
        {
            var transations = new List<Transaction>
            {
                new Transaction {Date = new DateTime(2014, 04, 01), Amount = 1000},
                new Transaction {Date = new DateTime(2014, 04, 2), Amount = -100},
                new Transaction {Date = new DateTime(2014, 04, 10), Amount = 500}
            };

            var console = new Console();
            var transactionRepository = new Mock<ITransactionRepository>();
            transactionRepository
                .Setup(ts => ts.GetAll())
                .Returns(transations);

            var account = new Account(transactionRepository.Object, console);

            account.PrintStatement();

            transactionRepository.Verify(ts => ts.GetAll(), Times.Once);
            console.Out.ShouldEqual(
                  "DATE | AMOUNT | BALANCE" + Environment.NewLine +
                  "10/04/2014 | 500.00  | 1400.00" + Environment.NewLine +
                  "02/04/2014 | -100.00 | 900.00" + Environment.NewLine +
                  "01/04/2014 | 1000.00 | 1000.00");

        }
    }
}
