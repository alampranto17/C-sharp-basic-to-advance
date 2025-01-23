using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{
    internal class Customer : Person
    {
        private string customerId;
        
        internal override string Id
        {
            get { return this.customerId; }
            set
            {
                base.Id = value;
                this.customerId = base.Id + "-C";
            }
        }
        
        internal string IteamName
        {
            get; set;

        }

        internal Customer(string name, int age, AddressFormate address,string itemName) : base(name,age,address)
        {
            this.Id = "";
            this.IteamName = itemName;
        }

        public override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Item Name : " + this.IteamName);
            Console.WriteLine();

        }
    }
}
