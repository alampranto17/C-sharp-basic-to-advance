using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midPractices
{
    internal class Laptop : Computer
    {
        private Char chargeType;
        private bool isThanderPort;
        private bool isHdCam;
        private bool isFingerprint;

        internal Char ChargeType
        {
            get { return this.chargeType; }
            set { this.chargeType = value; }
        }
        internal bool IsThanderPort
        {
            get { return this.isThanderPort; }
            set { this.isThanderPort = value; }
        }
        internal bool IsHdCam
        {
            get { return this.isHdCam; }
            set { this.isHdCam = value; }
        }
        internal bool IsFingerprint
        {
            get { return this.isFingerprint; }
            set { this.isFingerprint = value; }

        }

        internal Laptop(int cpuClockSpeed, int ramCapcity, int ramClockSpeed, int gpuMemory, string operatingSystem, int operatingSystemVersion, int numberOfCore, bool isSsd, char chargeType, bool isThanderPort, bool isHdCam, bool isFingerprint) : base( cpuClockSpeed,  ramCapcity,  ramClockSpeed,  gpuMemory, operatingSystem, operatingSystemVersion, numberOfCore, isSsd)
        {
            this.ChargeType = chargeType;
            this.IsThanderPort = isThanderPort;
            this.IsHdCam = isHdCam;
            this.IsFingerprint = isFingerprint;
           
        }

       internal override void Print()
        {
            Console.WriteLine("Laptop Configaretion : ");
            base.Print();
            Console.WriteLine($"Charger type : {this.ChargeType}");
            Console.WriteLine($"Is thanderPort avabilable : {this.IsThanderPort}");
            Console.WriteLine($" Is HD cam avabilable : {this.isHdCam}");
            Console.WriteLine($"Is fingerprint avabilable  : {this.IsFingerprint}");
        }
        internal override void Queality()
        {
            Console.WriteLine("Laptop :");
            base.Queality();
            Console.WriteLine();
        }
    }
}
