using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SavingAccount : Account
    {
        public int duration;

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public SavingAccount(int id,string name,double balance,int duration) : base(id,name,balance)
        {
            this.Duration = duration;
        }
        public override void Withdraw(int ammount)
        {
            if (this.Balance - 500 >= ammount)
            {
                this.Balance -= ammount;
            }
            else
            {
                Console.WriteLine("Balance is less than 500");
            }
            this.PrintBalance();

        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Duration : {0}",this.Duration);
        }

    }
}
