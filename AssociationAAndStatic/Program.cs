using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationAAndStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Person person = new Employee("Pranto", 21, new AddressFormate(21, 300, "Kishoregonj", "Dhaka", "Bangladesh"), "AB+", "CLeaner", 1000.00);
             Person person1 = new Customer("Saad", 22, new AddressFormate(26, 303, "Kishoregonj", "Dhaka", "Bangladesh"), "cement");
             person.Showinfo();
             Console.WriteLine();
             person1.Showinfo();*/
            ListofValue.AddList(new Employee("Pranto", 21, new AddressFormate(21, 300, "Kishoregonj", "Dhaka", "Bangladesh"), "AB+", "CLeaner", 1000.00));
            ListofValue.AddList(new Customer("Saad", 22, new AddressFormate(26, 303, "Kishoregonj", "Dhaka", "Bangladesh"), "cement"));
            //ListofValue.ShowList();
            int index;
            /*ListofValue.SearchOption("P-1-C", out index);*/
            ListofValue.RemoveItem("P-1-C");
            ListofValue.ShowList();


        }
    }
}
