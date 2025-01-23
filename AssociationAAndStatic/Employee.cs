using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{
    internal class Employee : Person
    {


        private string employeeId; // Backing field for Employee-specific ID

        internal override string Id
        {
            get { return this.employeeId; }
            set { 
                base.Id = value;
                this.employeeId = base.Id + "-E"; 
            
            } // Append "-E" to the base ID


        }

        internal string BlooadGroup
        {
            get; set;
        }
        internal string TypeOfWork
        { get; set; }

        internal double Salary
        {
            get; set;
        }

        internal Employee(string name, int age, AddressFormate address,string blooadGroup,string typeofwork,double salary) : base(name,age,address)

            {
            this.Id = "";
            this.Salary = salary;
            this.BlooadGroup = blooadGroup;
            this.TypeOfWork = typeofwork;
            }

        public  override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Empolyee : " + this.TypeOfWork);
            Console.WriteLine("Blood Group : "+this.BlooadGroup);
            Console.WriteLine("Salary : "+this.Salary);
            Console.WriteLine(); 
            
        }

    }
}
