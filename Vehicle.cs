using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
        //return nothing-void
        public abstract void DriveAbstract(); //stubbed out method-no implementation
        // virtual method below can over ride later.
        public virtual void DriveVirtual()
        {
                               //string interp=saying this vehicle is in drive
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }  // virtual method ^ this method has implementatio bc of scope {}= stuff it will do
    }

}
