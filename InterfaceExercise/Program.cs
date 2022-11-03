using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //DONE In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONE In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            

            var car1 = new Car()
            {
                Name = "Lightning McQueen",
                BodyStyle = "coup",
                CorporateType = "c corp",
                HasSunroof = true,
                IsAWD = false,
                NumberOfDoors = 2,
                NumberOfWheels = 4,
                SeatingCapacity = 2,
                TaxID = "8345612"
            };
            

            var truck1 = new Truck()
            {
                Name = "Trucky McTruckerson",
                BedLength = 5,
                TowingCapacity = 9500,
                TaxID = "1245612",
                SeatingCapacity = 5,
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                CorporateType = "s corp",
                IsAWD = false
            };
            

            var SUV1 = new SUV() 
            { 
                Name = "Just a Station Wagon",
                IsAWD = true, 
                CorporateType = "c corp", 
                NumberOfDoors = 4, 
                NumberOfWheels = 4, 
                SeatingCapacity = 8, 
                TaxID = "45987654", 
                CargoCapacity = 25, 
                HasThirdRow = true 
            };

            var vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(SUV1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"{veh.Name}");
                veh.PrintStats();
            }
            
       
            Console.WriteLine($"{SUV1.Name} has {SUV1.NumberOfDoors} doors and a cargo capacity of {SUV1.CargoCapacity}");
            Console.WriteLine($"{car1.Name} is a {car1.BodyStyle} and has a seating capacity of {car1.SeatingCapacity}");
            Console.WriteLine($"{truck1.Name} has a bed length of {truck1.BedLength} and a towing capacity of {truck1.TowingCapacity}");
        }
    }
}
