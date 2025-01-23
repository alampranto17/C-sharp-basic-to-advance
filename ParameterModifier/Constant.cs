using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier

{
   /* struct alam
    {
        readonly int b = 10;
    }*/
    internal class Constant
    {
        const int a = 100;// this value will never change.you can not even edit it;

        readonly int b;
        readonly int c=10;
        // initilize er dorkar hoy na ,and constuct er vitore change kora jai 
        //class er vitore initilize kora jai but struct er vitore kora jai na 
        public Constant()
        {
            this.b = a;
        }


    }
}
