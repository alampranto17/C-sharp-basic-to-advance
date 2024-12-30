using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Program
    {
        static void Main(string[] args)
        { 


            //using params unlimite number parameter pass

            Params p= new Params();
            p.Addition(12, 67, 78, 987, 45);
            p.Addition(12, 56, 4);
            // you can send everything like object etc;

            RefAndOut r = new RefAndOut();
            int i = 10;
            int j = 90;
          
            Console.WriteLine("before "+i + " " + j);
            r.Swap(ref i, ref j);   // ref likhte hoy 
            Console.WriteLine("after " + i +" "+j);

            int p1;
            int p2;

            r.Sum(out p1, out p2); // data hiding is very useful out
            Console.WriteLine(p1);

            //optional parameter passing 
            int x = 159;
            int y = 0909;
            r.sum(x, y);
            r.sum(x, y, 123);

            //enums

            Enums e= new Enums();
            e.print(0);
            e.LevelPrint(0);
            e.LevelPrint(2);


            





        }
    }
}
