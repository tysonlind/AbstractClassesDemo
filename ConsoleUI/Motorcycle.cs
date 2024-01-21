using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public int MaxSpeed { get; set; }
        public bool IsBulletBike { get; set; }
        public Motorcycle() { }

        public override void DriveAbstract()
        {
            Console.WriteLine("implementation of DriveAbstract");
        }
    }
}
