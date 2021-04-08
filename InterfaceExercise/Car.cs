using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        
        public string VehicleSize { get; set; }
        public string TrunkSize { get; set; }

        // from interface
        public string Logo { get; set; }
        public string IsDomestic { get; set; }
        public int HowManyDoors { get; set; }
        public string IsAllWheelDrive { get; set; }
        public bool HasSirius { get; set; }
        public string NavigationType { get; set; }
        public string Make { get; set; }
    }

}

