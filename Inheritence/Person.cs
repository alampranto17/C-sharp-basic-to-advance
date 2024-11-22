using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    struct AddressFormate
    {
        private short houseNo;
        private string city;


        public short HouseNo
        {
            get {  return this.houseNo ; }
            set
            {
                this.houseNo = 0;
                if (value > 0 && value <= 100)
                { 
                    this.houseNo = value ;
                }
                
            }

        }

        public string City
        {
            get { return this.city ; }
            set { this.city = value ; }
        }

        public AddressFormate (short houseNo,string city)
        {
            this.houseNo = 0;// before using property use this in structure;
            this.city = null;

            HouseNo= houseNo ;
            this .City = city ; 
        }
        /*
               public void Print()
                {
                    Console.WriteLine($"House No : {this.HouseNo} , City Name : {this.City}");
                }
        */

        public override string ToString()
        {
            return $"House No : {this.HouseNo} , City Name : {this.City}";
        }


    }
    internal class Person
    {
        private String name;
        private int age;
        private AddressFormate address;

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
       public AddressFormate Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Person(string name ,int age,AddressFormate address)
        {
            this .Name = name ;
            this .Age = age ;
            this.address = address ;
        }
       

       
        
    }
}
