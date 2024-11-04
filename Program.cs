using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace classworkofc_
{
    struct Point
    {
        public int x; // this is like java. you have to used access modifier every value.
        public int y;


        // C# is not working on this constructure 
        //public point()
        //{
        //    this.x = 6; this.y = 0;
        //}

        public Point(int x, int y) // parameter constructure
        {
            this.x = x;
            this.y = y;
        }

        public void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    };

    internal class Program
    {
        static void Main(string[] args)
        {

            /*int a = 10, b = 20;
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

            // Read word --> assikey value

            Console.WriteLine("enter a character");
            int arr = Console.Read();
            Console.WriteLine($"character assikey value : {arr}");*/

            //class 2 update 29-11-24

            Point P;
            P.x = 10;
            P.y = 20;
            Console.WriteLine($"X= {P.x} , y= {P.y}");

            P = new Point(10, 12);

            Console.WriteLine($"X= {P.x} , y= {P.y}");

            Point P1= new Point(21, 12);
            P1.print();

            Point P3 = P1;  //p1 copy send to p3 but p1 will not affected
            P3.x++;
            P3.y++;

            P3.print();
            P3.x = Int32.Parse(Console.ReadLine());
            P3.y= Int32.Parse(Console.ReadLine());
            P3.print();


            








        }
    }

}
