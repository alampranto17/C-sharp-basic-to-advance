using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student[] s = new Student[2];
            int i = 0;
            while (i < s.Length)
            {
                Console.Write("Enter Your Id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Name : ");
                string name= Console.ReadLine();
                Console.WriteLine();

                Console.Write("House Number  : ");
                  short houseNo =Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Road Number  : ");
                short roadNo = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Division : ");
                string division = Console.ReadLine();
                Console.WriteLine();

                s[i] = new Student(id, name, new Address(roadNo, houseNo, division));
                i++;
            }*/

           /* Polymorphism p= new Polymorphism();
           // p.Addition(s);

            p.Addition("alam", 233, 133);
            p.Addition(23, "alam", 466);
            p.Addition(21, 2445, 5667);
            int[] arr = new int[4] { 1, 2, 3, 4 };
            p.Addition(arr);*/

            //runtime polymorphism 
            /*
             * return type same 
             * name same 
             * parameter same 
             *
             * 
             */

            PrimaryStudent p = new PrimaryStudent();
            Student s=new Student();
            s.Print();//override er condition full but override not posiable
            p.Print();

            // if we want to override we need to used polymorphie object 

            Student ab = new PrimaryStudent();// this polymorphic object 
            ab.Print();
                        // always print the upgrade able thing and jodi upgrade method na pai tahole print korbe ager tai 





        }
    }
}
