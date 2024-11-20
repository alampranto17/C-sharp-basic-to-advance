using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfphism
{
    internal class Polymorphism
    {
        //Polymorphism -> bohurupi 
        //2 type of polymorphism -> method overloading (compile time) ,method overriding (run time)
        //condition of polymorphism -> 1. Number of parameter 2. type of parameter 3. sequence of parameter
        // jokhon compile kore tokhon dekha je kun method call kora possible tai eke compile time polymorphism bole 
        // normaly overloading work in finite time 

        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Addition(int a, int b, int c) { Console.WriteLine(a + b + c); } // number of parameter

        public void Addition(string p, int b, int c)    // number of type 
        {
            Console.WriteLine(p + "= " + b + " + " + c);

        }

        public void Addition(int a, string b, int c) //sequence of parameter 
        {
            Console.WriteLine(b + "= " + a + " + " + c);
        }

        public void Addition(int[] arr) //arr passing 
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public void Addition(Student[] s ) //objct of array 
        {
            foreach (Student i in s)
            {
                i.Print();
            }
        }
    }
}
