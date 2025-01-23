using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{
    struct AddressFormate
    {
        private short roadNo;
        private short houseNo;
        private string area;
        private string city;
        private string country;

        internal AddressFormate(short roadNo, short houseNo, string area, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.area = area;
            this.city = city;
            this.country = country;
        }
        internal void ShowAddress()
        {
            Console.WriteLine("---------------------------------------------------------------- \n Address :- ");
            Console.WriteLine("Road NO : " + this.roadNo + ", House No : " + this.houseNo + ", Area : " + this.area);
            Console.WriteLine("City : " + this.city + ", country : " + this.country);
            Console.WriteLine("----------------------------------------------------------------");
        }
    }

    internal class Person
    {
        private static int count = -1;
        private string id;
        private string name;
        private int age;
        private AddressFormate address;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal virtual string Id
        {
            get { return this.id; }
            set { 

                    
                this.id = "P-" + Convert.ToString(++count);
            
            
            }


        }

        internal int Age
        {
            get { return this.age; }
            set
            {

                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    this.age = -1;
                }


            }
        }

        internal AddressFormate Address
        {
            get { return this.address; }
            set { this.address = value; }

        }

        internal Person( string name, int age, AddressFormate address)
        {
          
            this.Name = name;
            this.Age = age;
            this.Address = address;

        }

        public virtual  void Showinfo()
        {
            Console.WriteLine("ID : "+this.Id);
           
            Console.WriteLine("Name : " + this.Name);
        
            Console.WriteLine("Age : " + this.Age);

            this.Address.ShowAddress();

        }

    }
}