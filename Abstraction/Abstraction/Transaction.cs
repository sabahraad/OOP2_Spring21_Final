using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Transaction
    {
        private Account sender;
        private Account receiver;
        public double Amount { get; set; }
        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            AdditionalInfo = additionalInfo;
            Amount = amount;
        }

        public void showTransactions()
        {
            Console.WriteLine("Transaction type: {0} ", AdditionalInfo);
            Console.WriteLine("Amount: " + Amount);
           
                Console.WriteLine("Sender: {0}({1})", sender.AccName, sender.AccNo);
                Console.WriteLine("To: {0}({1})", receiver.AccName, receiver.AccNo);
            
        }
    }
}
