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
            public Account() { }
            
           public Account(string accName, string accNo, double balance) {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
        }
            
        abstract public void ShowInfo();

            
        abstract public void Deposit(double amount);
            
        abstract public void Withdraw(double amount);

        abstract public void Transfer(Account a, double amount);


    }
}
