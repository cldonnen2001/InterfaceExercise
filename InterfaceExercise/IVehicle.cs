using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle 
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */

     
        //properties
        public string Make { get; set; }
        public int HowManyDoors { get; set; }
        public string IsAllWheelDrive { get; set; }
        public bool HasSirius { get; set; }
        public string NavigationType { get; set; }


        //method

        // public void Color();


    }
}
