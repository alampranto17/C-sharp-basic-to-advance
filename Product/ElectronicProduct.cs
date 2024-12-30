using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class ElectronicProduct : Product
    {
        private int battaryCapacity;
        internal int BattaryCapacity
        {
            get { return this.battaryCapacity; }
            set { this.battaryCapacity = value; }
        }

       




        internal ElectronicProduct(string name, double price, int battaryCapacity) : base(name, price)
        {

            this.BattaryCapacity = battaryCapacity;


        }
        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine($"BattaryCapacity = {this.BattaryCapacity} %");

            Console.WriteLine();

        }
    }
}
