﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch(vehicleType)
            {
                case "2":
                    return new Bicycle();
                case "3":
                    return new Tricycle();
                case "4":
                    return new GoCart();
                default:
                    return new GoCart();
               
               

            }








        }










    }
}
