using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
     

        }
          
            // Has a side cart is property
        public bool HasSideCart { get; set; } = false;
               //override modifier using DriveAbstract method
        public override void DriveAbstract()
        {
            //implementation
            Console.WriteLine("This Motocycle is in drive!");
        }
        public override void DriveVirtual()
        {
           Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }


    }
}
