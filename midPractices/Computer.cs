using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace midPractices
{
    internal class Computer
    {
       private  int cpuClockSpeed;
        private int ramCapcity;
        private int ramClockSpeed;
        private int gpuMemory;
        private string operatingSystem;
        private int operatingSystemVersion;
        private int numberOfCore;
        private bool isSsd;

        internal int CpuClockSpeed
        {
            get { return this.cpuClockSpeed; }
            set
            {
                if (value > 0 && value<10)
                { this.cpuClockSpeed = value; }
                else
                {
                    this.cpuClockSpeed = -1;
                }
            }
        }
        internal int RamCapcity
        {
            get { return this.ramCapcity; }
            set
            {
                if (value > 0 && value <= 64)
                { this.RamCapcity = value; }
                else
                {
                    this.RamCapcity = -1;
                }
            }
        }



        internal int RamClockSpeed
        {
            get { return this.ramClockSpeed; }
            set { if(value>800 && value<6800)                
                this.ramClockSpeed = value;
            else this.cpuClockSpeed= -1;
            }
        }
        internal int GpuMemory
        {
            get { return this.gpuMemory; }
            set { 
                if(value>2 && value<32)
                this.gpuMemory = value; 
                else 
                    this.gpuMemory = -1;
            
            }
        }
        internal string OperatingSystem
        {
            get { return this.operatingSystem; }
            set { this.operatingSystem = value; }
        }
        internal int OperatingSystemVersion
        {
            get { return this.operatingSystemVersion; }
            set {
                if(value>=0)
                this.operatingSystemVersion = value;
            else this.operatingSystemVersion= -1;
            }
            
           
        }
                
        internal int NumberOfCore
        {
            get { return this.numberOfCore; }
            set { if (value >= 4 && value <= 16)
                    this.numberOfCore = value;
                else this.numberOfCore= -1;
                        }
        }

        internal bool IsSsd
        {
            get { return this.isSsd; }
            set { this.isSsd = value; }
        }

        internal  Computer(int cpuClockSpeed, int ramCapcity, int ramClockSpeed, int gpuMemory, string operatingSystem, int operatingSystemVersion, int numberOfCore, bool isSsd)
        {
            this.cpuClockSpeed= cpuClockSpeed;
            this.ramCapcity= ramCapcity;  
            this.ramClockSpeed= ramClockSpeed;
            this.gpuMemory= gpuMemory;
            this.operatingSystem= operatingSystem;
            this.operatingSystemVersion= operatingSystemVersion;
            this.numberOfCore= numberOfCore;
            this.isSsd= isSsd;

        }

        internal virtual void Print()
        {
            
            Console.WriteLine($"CPU Clock Speed : {this.CpuClockSpeed}");
            Console.WriteLine($"RAM Capcity : {this.RamCapcity}");
            Console.WriteLine($"RAM Speed : {this.RamClockSpeed}");
            Console.WriteLine($"GPU Memory : {this.GpuMemory}");
            Console.WriteLine($"Oparaing System : {this.OperatingSystem}");
            Console.WriteLine($"Oparaing System Version  : {this.OperatingSystemVersion}");
            Console.WriteLine($"Number of Core : {this.NumberOfCore}");
            Console.WriteLine($"Is SSD Avabilable  : {this.IsSsd }");

        }

        internal virtual void Queality()
        {
            if(this.RamCapcity<=4 && this.CpuClockSpeed==1 && isSsd==false )
            {
                Console.WriteLine("Quality : Poor");
            }
           else if ((this.RamCapcity>4 && this.RamCapcity<=16 ) && (this.CpuClockSpeed <= 3 && this.CpuClockSpeed>1) && isSsd == true)
            {
                Console.WriteLine("Quality : Average");
            }
            else
            {
                Console.WriteLine("Quality : High");
            }
        }


        
        

        




    }
}
