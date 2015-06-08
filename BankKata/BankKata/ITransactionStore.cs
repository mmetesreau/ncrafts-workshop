using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankKata
{
    public interface ITransactionRepository
    {
        void Store(Transaction transaction);
        List<Transaction> GetAll();
    }

    public class Transaction
    {
        public DateTime Date;
        public int Amount;
    }
}
