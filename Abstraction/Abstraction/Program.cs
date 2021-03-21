using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Account r = new SpecialSaving("Raad", "99999999", 50, 15);
            Account s = new SpecialSaving("Saad", "7777777", 500, 300);

            Account ru = new OverDraft("Rudmila", "5555555", 100, 50);
            Account sh = new OverDraft("Shahed", "999555777", 10000, 5000);

            r.ShowInfo();
            r.Deposit(500);
            r.Withdraw(200);
            r.Transfer(s, 20);
            r.showAllTransaction();

            ru.ShowInfo();
            ru.Deposit(2000);
            ru.Withdraw(50);
            ru.Transfer(sh, 100);
            ru.showAllTransaction();

        }
    }
}
