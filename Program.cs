using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace classworkofc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = 10, b = 20;
            Console.WriteLine("hello world");
            Console.Write("hello ,i am alam Pranto\n");
            Console.WriteLine($"a={a} b={b}");  // system 1 
            Console.WriteLine("a={0}b={1}",a,b); // system 2
            Console.WriteLine("a = " + a + " b = " + b); // system 3

            // taking input 
            Console.WriteLine("Enter your name : ");
            string s=Console.ReadLine();    // string input
            Console.WriteLine($"name : {s}");
            Console.WriteLine("Enter your age : ");


            string p = Console.ReadLine(); // intiger input 
            int n= Int32.Parse(p);   // way one     
            Console.WriteLine($"Age : {n}");


            Console.WriteLine("how many money you have ?");
            float money= (float)Convert.ToDouble(Console.ReadLine()); // float + double
            Console.WriteLine($"money = {money}");


            Console.WriteLine("Enter your names first charater");
            char charinput= Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"your first charater : {charinput}"); // character input
            

            // Readkey word 
            Console.WriteLine("enter a character");
            ConsoleKeyInfo z = Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine($"key={z.Key}");
            Console.WriteLine($"character : {z.KeyChar}");
            Console.WriteLine($"Modifer= {z.Modifiers}");

            // Read key word --> assikey value

            Console.WriteLine("enter a character");
            int arr = Console.Read();
            Console.WriteLine($"character assikey value : {arr}");






        }
    }

}
