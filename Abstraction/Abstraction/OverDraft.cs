using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class OverDraft:Account
    {
        public int Limit { get; set; }
        public OverDraft()
        {

        }
        public OverDraft(string accName, string accNo, double balance, int limit) : base(accName, accNo, balance)
        {
            Limit = limit;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + Limit + amount;
            Console.WriteLine("Your acc is credited by " +amount+ "New balance:" + Balance);
        }
        public override void Withdraw(double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                Console.WriteLine("Your acc is debited by "+amount+ "New balance : "+ Balance);
            }
            else
            {

                Console.WriteLine("Insuffient Balance maximum amount you can withdraw is:" + (Balance + Limit));
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;


                Console.WriteLine("You account is debited by {0} new balance {1} and credited to  acc: {2} ({3})", amount, Balance, a.AccName, a.AccNo);
            }
            else
            {
                Console.WriteLine("Insuffient Balance maximum amount you can transfer is:" + (Balance + Limit));
            }

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);

        }


    }
}
