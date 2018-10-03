using System;
using System.Collections.Generic;

namespace Banking.Models.Domain {
    public class Transaction {

        #region Properties
        public decimal Amount { get; }

        public TransactionType TransactionType { get; }

        public DateTime DateOfTransaction { get; }

        public bool IsWithdraw {
            get {
                return TransactionType == TransactionType.Withdraw;
            }
        }

        public bool IsDeposit {
            get {
                return TransactionType == TransactionType.Deposit;
            }
        }

        public IEnumerable<Transaction> Transactions { get; }
        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType transactionType) {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTransaction = DateTime.Today;
        }
        #endregion
    }
}
