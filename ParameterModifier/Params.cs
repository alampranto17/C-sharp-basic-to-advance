using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Params
    {
        // Params is an important keyword in C#.
        // It is used as a parameter which can take the variable number of arguments.
        //It is useful when programmer don’t have any prior knowledge about the number of parameters to be used.

        // 3 condition
        //1. array use korte hoy 
        //params method e ekbar likha jai
        // always right most parameter e likhte hoy 

        public void Addition(params int[] number ) {

            int sum = 0;
            foreach (int i in number)
            {
                sum += i;
            }
        Console.WriteLine( sum );  
        }


    }
}
