using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classworkofc_
{

    struct AddressFormate
    {
        private byte houseNo;
        private byte roadNo;
        private string area;
        private string city;
        private int zip;
        private string country;

        public  byte HouseNo
        {
            get { return this.houseNo; }
            set { this.houseNo = value; }
         
        }

        public byte RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }

        public string Area
        {
            get { return this.area; }

        set { this.area = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public  int Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }

        }




        // struct constructor can't used property before Initialize you can't used it 
        public AddressFormate( byte houseNo,byte roadNo,string area ,string city, int zip, string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
            this.city = city;
            this.zip = zip;
            this.country = country;

        }

        public void print()
        {
            Console.WriteLine($"House No : {this.HouseNo}, Road NO : {this.RoadNo}, Area : {this.Area}, City : {this.City}, Zip : {this.Zip} , Country : {this.Country}");
        }

        //public void print()
        //{
        //    Console.WriteLine($"House No : {this.houseNo}, Road NO : {this.roadNo}, Area : {this.area}, City : {this.city}, Zip : {this.zip} , Country : {this.country}" );
        //}

        /*public string GetAddress()
        {
            return $"House No : {this.houseNo}, Road NO : {this.roadNo}, Area : {this.area}, City : {this.city}, Zip : {this.zip}";
        }*/
        //if you need induvisul accress your file you need to use propertices 
        // public int propertics_name
        /* {
         *   get{ returen this.houseNO;}
         *   set{this.houseNo = value}
         }*/

        //value is a keyword;



    }
    internal class InfoStore
    {
        private int id;
        private string name;
        private double cgpa;
        private AddressFormate address;


        // Property with get and set accessors 
        // naming convention should be Pascal Case and the same name of field
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

        public double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if (value >= 0.00 && value <= 4.00)
                    this.cgpa = value;
                else this.cgpa = -1;
            }
        }


        public AddressFormate Address
        { get { return this.address; }
          set { this.address = value; }
        } 
        
        public InfoStore()
        { }

        public InfoStore(int id, string name, double cgpa, AddressFormate address)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa= cgpa;
            this.Address = address;
            
        }
        private String GradeReport()
        {
            if(this.Cgpa ==-1)
            {
                return "Invalid";
            }
            else if(this.Cgpa>=3)
            {
                return " A+";  
            }
            else if (this.Cgpa >= 2)
            {
                return " +B";
            }
            else { return "C+"; }
        }

        public void print()
        {
            Console.WriteLine("Printing Inforemation About the person");
            Console.WriteLine($"ID : {this.Id}");
            Console.WriteLine($"NAME : {this.Name}");
            Console.WriteLine($"CGPA : {this.Cgpa}");
            Console.WriteLine($"GRADE RESULT : {this.GradeReport()}");
            

            Console.Write($"ADDRESS : ");
            this.Address.print();
            Console.WriteLine();
        }
    }
}
