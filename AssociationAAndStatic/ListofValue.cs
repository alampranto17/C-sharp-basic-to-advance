using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{   //static mane eita pura project er vitore ekta class ei thakte parbe er kuno copy kokhono possible na .
    // class jodi static hoy tahole er vitore shob compoment hobe static 
    // amra database theke operation korte onek time nei tai amra eita ke code niye chole asi tar pore er upore operation kore thaki 
    internal static class ListofValue
    {
        static int count = 0;
        private static Person[] personlist = new Person[2000];
        // adding as list of element
        internal static void AddList(Person p)
        {
            personlist[count] = p;
            count++;
        }
        //show info method
        internal static void ShowList()
        {
            int index = 0;
            while (index < count)
            {
                if (personlist[index] != null)
                {
                    personlist[index].Showinfo();
                    index++;
                }
            }

        }

        internal static Boolean SearchOption(string value, out int index)
        {
            bool flag = false;

            index = -1;
            int i = 0;
            while (i <= count)
            {

                if (personlist[i] != null && personlist[i].Id == value)
                {
                    index = i;
                    flag = true;
                    break;
                }

                i++;
            }
            if (!flag)
            {
                Console.WriteLine("Status : value! not found");
            }
            else
            {
                Console.WriteLine("Status : value is found");
                /*personlist[index].Showinfo();*/
            }

            return flag;
        }


        internal static Boolean RemoveItem(string value)
        {

            bool flag = SearchOption(value, out int index);

            personlist[index] = null;




            return flag;

        }



    }
}

