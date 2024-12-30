using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class CosmeticProduct : Product
    {
        private DateTime expireDate;
        private string manufacture;
        private string v1;
        private DateTime dateTime;
        private string v2;

        internal string Manufacturer
        {
            get { return this.manufacture; }
            set { this.manufacture = value; }
        }
        internal DateTime ExpireDate
        {
            get { return this.expireDate; }
            set { this.expireDate = value; }
        }
        internal CosmeticProduct(string name, double price, DateTime expireDate, string manufacture) : base(name, price)
        {
            this.ExpireDate = expireDate;
            this.Manufacturer = manufacture;

        }

        

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine($"Expire Date : {this.ExpireDate}");
            Console.WriteLine($"Manufacture : {this.Manufacturer}");
            Console.WriteLine();
        }

    }
}
