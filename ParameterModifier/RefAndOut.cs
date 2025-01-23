using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class RefAndOut
    {
        //ref and out both are passing reference type;
        //difference is that ref -> must be initilize before passing but out -> without initilize you can pass 
        public void Swap(ref int i ,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
           
        }
        public void Sum(out int p1,out int p2)
        {
            p1 = 100;
            p2 = 98;
            p1= p1+ p2;
            
        }
        public void sum(int i,int j,int p=0)
        {
           int  sum = i + j + p;
            Console.WriteLine(sum);
        }

    }
}
