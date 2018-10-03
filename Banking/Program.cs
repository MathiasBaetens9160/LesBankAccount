using Banking.Models.Domain;
using System;
using System.Collections.Generic;

namespace Banking
{
    static class Program
    {
        static void Main(string[] args)
        {

            //Object Initializer
            //BankAccount anotherBA = new BankAccount() {
            //    AccountNumber = "123-12312334-99",
            //    Balance = 200
            //};

            BankAccount myBA = new BankAccount("123-12312312-99", 50);

            Console.WriteLine($"Account number is {myBA.AccountNumber}");
            //Console.WriteLine($"Withdraw cost is {BankAccount.WithdrawCost} Euro");
            Console.WriteLine($"Balance is {myBA.Balance} Euro.");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro.");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro.");

            //IEnumerable<Transaction> transactions = myBA.Transactions;
            //var transactions = myBA.Transactions;
            foreach(var item in myBA.Transactions) {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }

            Console.ReadKey(); //Zodat console niet onmiddelijk afsluit
        }
    }
}
