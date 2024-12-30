using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer[] c = new Computer[2];
            c[0] = new Laptop(3, 4, 3200, 6, "windows", 7, 6, false, 'c', true, true, true);
           /* c[0].Print();
            c[0].Queality();*/

            c[1] = new Desktop(4, 5, 3200, 7, "windows", 10, 8, true, true, true, "Tiger");
          /*  c[1].Print();
            c[1].Queality();*/
          foreach(Computer computer in c) 
                {
                computer.Print();
                computer.Queality();
                Console.WriteLine();
                }
        }
    }
}
