using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{//static mane eita pura project er vitore ekta class ei thakte parbe er kuno copy kokhono possible na .
    // class jodi static hoy tahole er vitore shob compoment hobe static 
    // amra database theke operation korte onek time nei tai amra eita ke code niye chole asi tar pore er upore operation kore thaki 
    internal static class ListofValue
    {
        static int count = 0;
        private static Person[] personlist = new Person[2000];
        // adding as list of element
        internal static void AddList(Person p)
        {
            personlist[count++] = p;
        }
        //show info method
        internal static void ShowList()
        {
            int index = 0;
            while (index < count)
            {
                personlist[index].Showinfo();
                index++;
            }

        }
    }
}
