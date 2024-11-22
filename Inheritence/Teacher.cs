using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Teacher : Person
    {
        private int teacherId;
        private Double salary;

        public int TeacherId
        {
            get { return this.teacherId; }

            set
            {
                this.teacherId = value;

            }

        }
        public Double Salary
        {
            get { return this.salary; }
            set
            {
                double rateVat = 0.20;
                double totalVat = value * rateVat;
                this.Salary = value + totalVat;
            }

        }

        public Teacher(String name, int age, AddressFormate address,int teacherId,double salary) : base (name,age,address)
        {
                this.TeacherId = teacherId;
                this.Salary = salary;
        }

        public void TeacherInfoPrint()
        {
            Console.WriteLine("Teacher Name : "+this.Name);
            Console.WriteLine("Teacher Id :"+TeacherId);
            Console.WriteLine("Age : "+Age);
            Console.WriteLine("Salary : "+Salary);
            Console.WriteLine("Address : "+Address);

        }


    }
}
