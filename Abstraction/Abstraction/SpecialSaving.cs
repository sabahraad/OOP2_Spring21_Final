using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class SpecialSaving:Account
    {
        public double OpeningBalance { get; set; }
        public SpecialSaving() { }

        public SpecialSaving(string accName, string accNo, double balance, double openingbalance) : base(accName, accNo, balance)
        {
            OpeningBalance = openingbalance;
        }
        public override void Deposit(double amount)
        {
            Balance = Balance + amount;

            Console.WriteLine("Your acc is credited by " + amount + " New balance: " + Balance);
            Transaction tr = new Transaction(this, this, amount, "Deposit");
            base.AddTransaction(tr);
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 20 * OpeningBalance / 100)
            {
                Balance -= amount;
                Console.WriteLine("Your acc is debited by "+ amount + "New balance :" + Balance);
                Transaction tr = new Transaction(this, this, amount, "Withdraw");
                base.AddTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient Balance maximum amount you can withdraw is:" + (Balance - (20 * OpeningBalance / 100)));

            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (Balance - amount >= 20 * OpeningBalance / 100)
            {
                Balance -= amount;
                a.Balance += amount;
                Console.WriteLine("You account is debited by {0} new  balance {1} and credited to  acc: {2} ({3})", amount, Balance, a.AccName, a.AccNo);
                Transaction tr = new Transaction(this, a, amount, "Transfer");
                base.AddTransaction(tr);
            }
            else
            {
                Console.WriteLine("Insufficient Balance maximum amount you can withdraw is:" + (Balance - (20 * OpeningBalance / 100)));

            }
        }

        public override void ShowInfo()

        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);

        }


    }
}
