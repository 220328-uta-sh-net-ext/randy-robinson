using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        // Properties of Bank Account
         private static int accountNumberSeed = 00200332279;
         public string Number { get; }
         public string Owner { get; set; }
         public decimal Balance
         {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
                }
         }
         private List<Transactions> allTransactions = new List<Transactions>();
         public void MakeDeposit(decimal amount, DateTime date, string note)
         {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            allTransactions.Add(deposit);
         }

         public void MakeWithdrawal(decimal amount, DateTime date, string note)
         {
            if (amount <= 0)
            {
               throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
            }
            //This method (the constructor method) is needed so that the main method can use this class and should be toward the end of build
            public BankAccount(string name, decimal initialBalance)
            {
                this.Owner = name;
                this.Number = accountNumberSeed.ToString();
                accountNumberSeed++;
                Owner = name;
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            }
        
    }
}
