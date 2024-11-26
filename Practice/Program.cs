using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] a = new Account[2];

            a[0] = new CurrentAccount(1244, "alam Pranto", 2500);
            a[1] = new SavingAccount(123, "Abid", 1000, 25);

            foreach (Account account in a)
            {
                account.Print();
            }
            a[0].Withdraw(1000);
            a[1].Withdraw(500);
            a[1].Withdraw(500);
            a[0].Withdraw(1000);
            a[0].Deposit(1000);
            a[1].Deposit(1000);
        }
    }
}
