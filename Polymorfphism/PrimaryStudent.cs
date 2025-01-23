using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfphism
{
    internal class PrimaryStudent : Student
    {
       public override void Print()
        {
            System.Console.WriteLine("child");
        }
    }
}
