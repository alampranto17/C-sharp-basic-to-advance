using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Account
    {
        private int id;
        private string name;
        private double balance;

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else
                {
                    this.id = -1;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value > 0)
                { this.balance = value; }
                else
                {
                    this.balance = 0;
                }
            }
        }

        public void Deposit(int ammount)
        {
            this.Balance += ammount;
            this.PrintBalance();            
        }

        public virtual void Withdraw(int ammount)
        {
            
        }

        public Account(int id, string name, double balance)
        {
            this.Id = id;
            this.Name = name;
            this.Balance = balance;
        }

        public void PrintBalance()
        {
            Console.WriteLine("Current Balance : " + this.Balance);
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id : {this.Id}");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Balance : {this.Balance}");
        }




    }
}
