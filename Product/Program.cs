using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new ElectronicProduct("IPhone 7", 600000, 80);

            p1.Showinfo();
            Product p2 = new ElectronicProduct("Iphone 14", 800000, 100);
            p2.Showinfo();



            Product p3 = new CosmeticProduct("Lipstrick", 200, new DateTime(2023, 02, 08), "Dhaka");
            p3.Showinfo();

            Product p4 = new CosmeticProduct("Face Wash", 200, new DateTime(2023, 02, 08), "Dhaka");
            p4.Showinfo();




        }

    }
}
