using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Student : Person 
    {
        private int studentId;
        private byte classNo;
        private char seactionName;

        public int StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value;
            }
        }
        public byte ClassNo
        {
            get { return classNo; }
            set { classNo = value; }
        }
        public char SeactionName
        {
            get { return seactionName; }

            set { seactionName = value; }
        }

        public Student (String name,int age, AddressFormate address, int studentId,byte classNo,char sectionName) : base(name,age,address)
        {
            this.StudentId = studentId;
            this.ClassNo = classNo;
            this.SeactionName = sectionName;
        }

        public void StudentInfoPrint()
        {
            Console.WriteLine("Student Name : "+this.Name);
            Console.WriteLine("Student ID : " + this.StudentId);
            Console.WriteLine("Class NO : " + this.ClassNo);
            Console.WriteLine("Section Name : " + this.SeactionName);
            Console.WriteLine("Student Age : " + this.Age);
            Console.WriteLine("Student Address : " + this.Address);
        }
            

    }
}
