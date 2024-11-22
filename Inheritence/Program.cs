using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    // interitence means one class (the derived class) to acquire properties
    // and methods from another class (the base class).
    /*normaly 2 type of inherritance 
     1.single  
     2. multipule inheritance (C# not support in class but interface is support it )
        // inheritance er modde jokhon child class er maddhome object call kore prothome 
    parent class e constructor ke call er object ke class kore er por child class er 
    construtor ke call kore 
    //parent class er constructor class korte -> base keyword use kora hoy 
    //parent class er modde shob shomoy commont element rakhte hoy;
     *
     * 
     * 
     * 
     * 
     * 
     */
     

    internal class Program
    {
        static void Main(string[] args)
        {
            // child c1 = new child(); // first call parent object then class child

            // this() and base () -> remember never make a circle . 

            //child C2 = new child("hello");
            Console.WriteLine("How many student info register : ");
            int n=Convert.ToInt32(Console.ReadLine());

            Student[] student=new Student[n];
            int i = 0;
            while(i < n) {
                Console.WriteLine("Student "+i);
                Console.WriteLine();

                Console.Write("Student Name :");
                String name = Console.ReadLine();
                Console.Write("Student ID : ");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Class NO : ");
                byte classno=Convert.ToByte(Console.ReadLine());

                Console.Write("Section Name : ");
                char section=Convert.ToChar(Console.ReadLine());



                Console.Write("Student Age : ");
                int age=Convert.ToInt32(Console.ReadLine());

                Console.Write("Student Address : ");
                short houseNo =Convert.ToInt16(Console.ReadLine());

                string city = Console.ReadLine();

                student[i] = new Student(name: name, age: age, address: new AddressFormate(houseNo, city), studentId: Id, classNo: classno,sectionName: section);

                i++;
                }
            foreach (Student s in student)
            {
                s.StudentInfoPrint();
                Console.WriteLine();
            }




        }
    }
}
