using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        Transaction[] transactions;
        public int transactionCount { get; set; }
        public Account() { }
            
        public Account(string accName, string accNo, double balance) 
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transactions = new Transaction[20];
        }
        public void AddTransaction(params Transaction[] transactionArr)
        {
            foreach (Transaction transaction in transactionArr)
            {
                this.transactions[transactionCount++] = transaction;
            }
        }
        public void showAllTransaction()
        {
            Console.WriteLine("\nTransaction history ({0})", AccName);

            for (int i = 0; i < transactionCount; i++)
            {
                Console.Write(i + 1 + ". ");
                transactions[i].showTransactions();
            }
        }

        abstract public void ShowInfo();

            
        abstract public void Deposit(double amount);
            
        abstract public void Withdraw(double amount);

        abstract public void Transfer(Account a, double amount);


    }
}
