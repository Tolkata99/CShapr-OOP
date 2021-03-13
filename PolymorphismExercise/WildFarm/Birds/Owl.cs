﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal;
using WildFarm.Foods;

namespace WildFarm.Birds
{
    public class Owl : Bird
    {
        private const double BaseWeightModifer = 0.25;

        private static HashSet<string> owlAllowedFood = new HashSet<string>()
        {
            nameof(Meat)
        };

        public Owl(string name, double weight,  double wingSize)
            : base(name, weight, owlAllowedFood, BaseWeightModifer, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
