﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            base.DefaultFuelConsumption = 8;
        }

        public override double FuelConsumption
        {
            get
            {
                return base.DefaultFuelConsumption;
            }
            set
            {
                this.DefaultFuelConsumption = value;
            }

        }

        
    }
}
