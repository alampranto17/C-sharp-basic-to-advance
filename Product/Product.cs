using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Product
    {
        static int serial = 000;
        private string id;
        private string name;
        private double price;

        internal  string Id
        {
            get { return this.id; }
            set
            {
                this.id = "P-00" + serial.ToString();
                serial = serial + 1;
            }

        }
        internal string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        internal double Price
        {
            get { return price; }
            set { this.price = value; }
        }

        internal Product(string name, double price)
        {
            this.Id = "";
            this.Name = name;
            this.Price = price;
        }

        public virtual void Showinfo()
        {
            Console.WriteLine($"ID = {this.Id}");
            Console.WriteLine($"Name = {this.Name}");
            Console.WriteLine($"Price = {this.Price}");

        }


    }
}
