using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain {
    public class BankAccount {
        //private string _accountNumber;
        #region Fields
        //public const decimal WithdrawCost = 0.10M;
        private decimal _balance; 
        #endregion

        #region Properties
        public string AccountNumber {
            get;
            private set;
        }

        public decimal Balance {
            get {
                return _balance;
            }
            private set {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }
        #endregion

        #region Constructors

        public BankAccount() {

        }
        public BankAccount(string accountNumber) {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber) {
            Balance = balance;
        }
        #endregion

        //public decimal GetBalance() {
        //    return _balance;
        //}

        //private void SetBalance(decimal value) {
        //    _balance = value;
        //}

        //public decimal Balance { get; private set; }
        

        #region Methods
        public void Deposit(decimal amount) {
            Balance += amount;
        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
        #endregion
    }
}
