using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CurrentAccount : Account
    {
        private int charge = 10;

        public CurrentAccount(int id, string name, double balance) : base(id, name, balance)
        { }

        public override void Withdraw(int ammount)
        {
            if(this.Balance-10>=ammount)
            {
                this.Balance -= (ammount + this.charge);
            }
            this.PrintBalance();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Charge : {0}", this.charge);
            Console.WriteLine();
        }
    }
}
