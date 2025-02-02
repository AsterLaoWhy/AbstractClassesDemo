﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */
            //DONE
            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicleList = new List<Vehicle>();

            var car1 = new Car() { hasRoof = false, year = "2019", make = "Ford", model = "Taurus" };
            Vehicle car2 = new Car() { year = "2019", make = "Ford", model = "Taurus" };
            var motorcycle1 = new Motorcycle() { hasTwoWheels = true,year = "2019", make = "Ducatti", model = "Tron" };
            Vehicle motorcycle2 = new Motorcycle() { year = "2019", make = "Ducatti", model = "Tron"};
            Console.WriteLine("We In there");
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * DONE
             * Set the properties values with object initializer syntax
             */
            //DONE
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicleList.Add(car1);
            vehicleList.Add(car2);
            vehicleList.Add(motorcycle1);
            vehicleList.Add(motorcycle2);
            foreach (var vehicle in vehicleList) 
            { 
                vehicle.DisplayInfo(); 
                Console.WriteLine("\n-----------------------------------------------\n");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
