using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    enum days : byte // by default int thake but type bole dewa jai 
    {
        sunday,//0
        monday,//1
        tuesday,//2
        wednesday = 0,
        friday,//1
        saterday//2
                //class er baire kora safe option hobe;
                // er madhome just ekti numeric value safe hoy jar karon e memory kom jaiga khai 
                //database handle er easy hoy 
    }

    enum Level
    {
        Low,
        Medium,
        High
    }

    internal class Enums
    {
        public void print(int i)
        {
            if (i == Convert.ToInt32(days.wednesday))
            {
                Console.WriteLine(days.wednesday);
            }
        }
        public void LevelPrint(int x)
        {
            Level myVar = (Level)x;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }



}
}
