using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfphism
{
    struct Address
    {
        private short roadNo;
        private short houseNo;
        private string division;

        public Address (short  roadNo, short houseNo,string division) //construtor must be full all feild 
        {  
          this.roadNo = roadNo;
          this.houseNo = houseNo;
          this.division = division;
        
        }

        public void Print()
        {
            Console.WriteLine("Road NUmber : "+ roadNo +" House Number : "+ houseNo + "Division : "+ division );
        }
            



    };
    internal class Student
    {
        private int id;
        private string name;
        private Address address;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Student()
        {

        }

        public Student(int id, string name, Address address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

/*        public void Print()
        {
            Console.WriteLine("Name : "+this.Name);
            Console.WriteLine( "ID : "+this.Id);
            address.Print();
        }*/

        public virtual void Print()
        {
            Console.WriteLine("parent");
        }


    }
}
