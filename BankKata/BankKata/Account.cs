using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class Account
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IConsole _console;

        public Account(ITransactionRepository transactionRepository, IConsole console)
        {
            _transactionRepository = transactionRepository;
            _console = console;
        }

        public Account()
        {
        }

        public void Deposit(int amount)
        {
            Store(Math.Abs(amount));
        }

        public void Withdrawal(int amount)
        {
            Store(-Math.Abs(amount));
        }

        public void PrintStatement()
        {
            var balance = 0;
            var orderedTansactions = _transactionRepository.GetAll().OrderByDescending(tr => tr.Date);

            _console.WriteLine("DATE | AMOUNT | BALANCE");

            foreach (var transaction in orderedTansactions)
            {
                balance += transaction.Amount;

                _console.WriteLine(string.Format("{0} | {1}.00 | {2}.00",
                    transaction.Date.ToString("dd/MM/yyyy"),
                    transaction.Amount,
                    balance));
            }
        }

        private void Store(int amount)
        {
            _transactionRepository.Store(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount
            });
        }
    }
}
