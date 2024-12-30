using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midPractices
{
    internal class Desktop : Computer
    {
        private bool islandPort;
        private bool isBoothtruth;
        private string cpuCaseType;

        internal bool IslandPort
        { get { return islandPort; } 
        set { islandPort = value; }
        
        }
        internal bool IsBoothtruth
        {
            get { return isBoothtruth; }
            set { isBoothtruth = value; }
        }
        internal string CpuCaseType
        { get { return cpuCaseType; } set { cpuCaseType = value; } }

        internal Desktop(int cpuClockSpeed, int ramCapcity, int ramClockSpeed, int gpuMemory, string operatingSystem, int operatingSystemVersion, int numberOfCore, bool isSsd, bool IslandPort, bool isBoothtruth,string cpuCase ) : base (cpuClockSpeed, ramCapcity, ramClockSpeed, gpuMemory, operatingSystem, operatingSystemVersion, numberOfCore, isSsd)

        {
            this.cpuCaseType = cpuCase;
            this.IsBoothtruth = isBoothtruth;
            this.IslandPort = islandPort;
        }
        internal override void Print()
        {
            Console.WriteLine("Desktop Configaretion : ");
            base.Print();
            Console.WriteLine($"CPU Case Type : {this.CpuCaseType}");
            Console.WriteLine($"Is LandPort avabilable : {this.IslandPort}");
            Console.WriteLine($" Is boothtruth  avabilable : {this.IsBoothtruth}");
          
        }

        internal override void Queality()
        {
            Console.WriteLine("Desktop :");
            base.Queality();
            Console.WriteLine();
        }
    }
}
