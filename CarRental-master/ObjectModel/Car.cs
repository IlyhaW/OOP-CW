﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   public class Car
    {
        public string Category { get; set; }
        public CarItem CarItem { get; set; }

        public Car()
        {
            CarItem = new CarItem();
        }
    }
}
