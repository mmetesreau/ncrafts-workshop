using NUnit.Framework;
using Should;
using System;
using System.IO;

namespace BankKata.Specs
{
    [TestFixture]
    public class PrintStatementsFeature
    {
        [Test]
        public void Print_All_Transactions()
        {
            var console = new Console();

            var account = new Account();

            account.Deposit(1000);
            account.Withdrawal(100);
            account.Deposit(500);

            account.PrintStatement();
            console.Out.ShouldEqual(
                  "DATE       | AMOUNT  | BALANCE" + Environment.NewLine +
                  "10/04/2014 | 500.00  | 1400.00" + Environment.NewLine +
                  "02/04/2014 | -100.00 | 900.00"  + Environment.NewLine +
                  "01/04/2014 | 1000.00 | 1000.00");
        }
    }
}
