using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */    // these below are objects could have put var in front of car/motorcycle
            Car tahoe = new Car() { HasTrunk = true, Make =  "Chevy", Model =  "Tahoe", Year =  2021 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = false, Make =  "Indian", Model = "Roadster", Year =  2019 };
            Vehicle truck = new Car() { HasTrunk = false, Make =  "Dodge", Model =  "Ram", Year =  2022 };
            Vehicle dirtbike = new Car() { HasTrunk = false, Make =  "suzuki", Model =  "Rav", Year =  2017 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             *
             */ // added the objects above
            vehicles.Add(tahoe);
            vehicles.Add(motorcycle);
            vehicles.Add(truck);
            vehicles.Add(dirtbike);
            //add each item in list below
            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make{veh.Make} Model{veh.Model} Year{veh.Year}");
                veh.DriveAbstract();// using cars bc we overrode motorcycle- over rode from motor below
                
                
                //override modifier using DriveAbstract method
               //  public override void DriveAbstract()
                // {
                 //implementation
                  //  Console.WriteLine("This Motocycle is in drive!");
               //  }
                //   public override void DriveVirtual()
                   // {
                    //  Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
                    //}






        Console.WriteLine("--------------------------");// creates space in between the vehicles
                // Console.WriteLine("-------"); looks like!
                // Make Ford Model Ram Year 2022
                //^------------------------- this!
                //Make chevy 
            }
                


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
