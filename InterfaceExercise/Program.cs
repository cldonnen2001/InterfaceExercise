using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany                                  done

            //Create 3 classes called Car , Truck , & SUV                                     done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
          
            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
           
            //Now, create objects of your 3 classes and give their members values;

            Truck truck1 = new Truck();
            truck1.Make = "Ford Ranger";
            truck1.HowManyDoors = 4;
            truck1.HasSirius = true;
            truck1.IsAllWheelDrive = "yes";
            truck1.IsDomestic = "no";
            truck1.Logo = "uuhhhh";
            truck1.NavigationType = "on my cell phone";
            truck1.TireSize = "P255";
            truck1.TruckBedSize = "60 to 72 inch";

            Car car1 = new Car();
            car1.Make = "Jaguar F-Type";
            car1.HowManyDoors = 2;
            car1.HasSirius = true;
            car1.IsAllWheelDrive = "yes";
            car1.IsDomestic = "yes";
            car1.Logo = "need to change this one";
            car1.NavigationType = "manufacturer";
            car1.TrunkSize = "small";
            car1.VehicleSize = "compact";

            SUV suv1 = new SUV();
            suv1.Make = "Ford Explorer";
            suv1.HowManyDoors = 4;
            suv1.HasSirius = true;
            suv1.IsAllWheelDrive = "yes";
            suv1.IsDomestic = "no";
            suv1.Logo = "fucking hell";
            suv1.NavigationType = "manufacturer";
            suv1.RowsOfSeats = 3;
            suv1.TowHitch = "yes";

            //without list
            // Creatively display and organize their values

            Console.WriteLine($"These are the vehicles that are for sale. {vehicles.Make}.  Descpriptions below: ");
            Console.WriteLine($"Doors: {truck1.HowManyDoors},  Sirius: {truck1.HasSirius}, All wheel drive: {truck1.IsAllWheelDrive}, Domestic/Foreign: {truck1.IsDomestic}" +
                $"Logo: {truck1.Logo}, Navagtion included: {truck1.NavigationType}, Trunk size: {truck1.TireSize}, Vehicle size: {truck1.TruckBedSize}");


            Console.WriteLine($"These are the vehicles that are for sale. {car1.Make}.  Descpriptions below: ");
            Console.WriteLine($"Doors: {car1.HowManyDoors},  Sirius: {car1.HasSirius}, All wheel drive: {car1.IsAllWheelDrive}, Domestic/Foreign: {car1.IsDomestic}" +
                 $"Logo: {car1.Logo}, Navagtion included: {car1.NavigationType}, Trunk size: {car1.TrunkSize}, Vehicle size: {car1.VehicleSize}");

            Console.WriteLine($"These are the vehicles that are for sale. {suv1.Make}.  Descpriptions below: ");
            Console.WriteLine($"Doors: {suv1.HowManyDoors},  Sirius: {suv1.HasSirius}, All wheel drive: {suv1.IsAllWheelDrive}, Domestic/Foreign: {suv1.IsDomestic}" +
                $"Logo: {suv1.Logo}, Navagtion included: {suv1.NavigationType}, Trunk size: {suv1.RowsOfSeats}, Vehicle size: {suv1.TowHitch}");



           // List<IVehicle> vehicles = new List<IVehicle>();

           // vehicles.Add(truck1);
           // vehicles.Add(car1);
           // vehicles.Add(suv1);

           //foreach (var vehicle in vehicles)
           //{
           //    Creatively display and organize their values

           //     Console.WriteLine($"These are the vehicles that are for sale. {vehicle.Make}.  Descpriptions below: ");
           //     Console.WriteLine($"Doors: {vehicle.HowManyDoors},  Sirius: {vehicle.HasSirius}, All wheel drive: {vehicle.IsAllWheelDrive},");
           //          Domestic/Foreign: {vehicle.IsDomestic} Logo: {vehicle.Logo}, Navagtion included: {vehicle.NavigationType}, Trunk size: {vehicle.TireSize}, Vehicle size: {vehicle.TruckBedSize}");
           //}

        }
    }
}
