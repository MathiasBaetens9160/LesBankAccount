using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain {
    public class SavingsAccount : BankAccount {

        #region Properties
        private const decimal WithdrawCost = 0.10M;

        public decimal InterestRate { get; private set; }
        #endregion

        #region Constructors
        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber) {
            InterestRate = interestRate;
        }
        #endregion
        
        #region Methods
        public override void Withdraw(decimal amount) {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        } 

        public void AddInterest() {
            Deposit(Balance * InterestRate);
        }
        #endregion
    }
}
