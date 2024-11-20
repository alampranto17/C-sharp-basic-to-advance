using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace classworkofc_
{
    struct Point // structure support  reference type and value type both. 
    {
        public int x; // this is like java. you have to used access modifier every value.
        public int y;


        // C# is not working on this constructure .constructure are mainly work for value initalization
        //public point()
        //{
        //    this.x = 6; this.y = 0;
        //}

        public Point(int x, int y) // parameter constructure .. er maddhome joto gula attribute ase shob gulai fill korte hobe
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
            //class 1

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
            /*
             Point P;
             P.x = 10;
             P.y = 20;
             Console.WriteLine($"X= {P.x} , y= {P.y}");

             P = new Point(31, 12);

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
            */
            


            //class 3 update ---

            //ClassModule c=new ClassModule();
            //c.SetId(22500003);
            //c.setName("Alam Pranto");
            //c.setAge(22);
            //c.setCgpa(3.50);

            //c.Print();

            //Console.WriteLine();

            //ClassModule c2=new ClassModule(22300002,"Nurul alam",24,-999.00);
            //c2.Print();



            //// class 4 update -- 
            //InfoStore S1=new InfoStore();
            //Console.WriteLine("Enter your ID : ");
            //S1.Id= Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ënter your name : ");
            //S1.Name=Console.ReadLine();
            //Console.WriteLine("Ënter your Cgpa : ");
            //S1.Cgpa=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ënter your Address : ");
            //S1.Address = new AddressFormate(120,07,"Uttara","Dhaka",1200,"Bangladesh");

            //S1.print();

            //InfoStore S2=new InfoStore(2290003,"Nurul",-999,new AddressFormate(109,08,"Addabor","Dhaka",2019,"Bangladesh"));
            //S2.print();

            //class 5 update 

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arred = new int[n];

            //int i = 0;
            //while (i < n)
            //{
            //    arred[i] = Convert.ToInt32(Console.ReadLine()); i++;
            //}

            ////for each loop 

            //foreach (int x in arred)
            //{
            //    {
            //        Console.WriteLine(x);
            //    }

            //}



            //  2D array and matrix multiplecation 
            //Console.WriteLine("2D array and matrix multiplecation");
            //int[,] arr= new int[2, 2] { {1, 2 },{ 3, 4 } };
            //int[,] arr1= new int[2, 2] { { 3,4},{5,6 } };
            //int[,] arr3 = new int[2, 2];


            //int j = 0;
            //while (j < 2)
            //{
            //    int k = 0;
            //    while (k < 2)
            //    {

            //        int p = 0;
            //        while(p<2)
            //        {
            //            arr3[j,k]+=arr[j, p] * arr1[p, k];
            //            p++;
            //        }

            //        k++;
            //    }

            //    j++;
            //}

            //int i = 0;
            //while(i< 2)
            //{
            //     j = 0;
            //    while(j<2)
            //    {
            //        Console.Write("{0} ",arr3[i, j]);
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            // jagged array : this like array of array nothing else 

            //Console.WriteLine("\n Jagged Array : ");
            //int[][] jagged = new int[2][];
            //jagged[0] = new int[2] { 1, 2 };
            //jagged[1] = new int[6] { 1, 2, 3, 4, 5, 6 };

            //int i = 0;
            //foreach (int[] row in jagged)
            //{
            //    foreach (int x in row)
            //    {
            //        Console.Write("{0} ", x);
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            ////2D jagged array 


            //int[][,] jagged2 = new int[2][,];
            //jagged2[0] = new int[2, 2] { { 1, 2 }, { 4, 3 } };
            //jagged2[1] = new int[2, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

            //for (int a = 0; a < jagged2.Length; a++) // Loop through each 2D array in the jagged array
            //{
            //    Console.WriteLine($"Printing array {a + 1} of jagged:");

            //    // Fixed loop variable typo: Changed i to j here
            //    for (int j = 0; j < jagged2[a].GetLength(0); j++) // Loop through rows of current 2D array
            //    {
            //        for (int k = 0; k < jagged2[a].GetLength(1); k++) // Loop through columns of current row
            //        {
            //            Console.Write($"{jagged2[a][j, k]} "); // Print each element with a space
            //        }
            //        Console.WriteLine(); // Newline after each row for readability
            //    }
            //    Console.WriteLine(); // Extra newline between arrays for clarity
            //}

            // The continue statement is used in loops to skip to the next iteration.

            // switch case 

            //char c = Convert.ToChar(Console.ReadLine());

            //switch (c)
            //{
            //    case 'a':
            //        {
            //            Console.WriteLine("You pass ");
            //            break;

            //        }
            //    case 'b':
            //        {
            //            Console.WriteLine("You fail");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Invalid ");
            //            break;
            //        }


        }


    }
    
}
