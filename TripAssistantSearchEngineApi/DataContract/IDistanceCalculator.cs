﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Contract
{
  public  interface IDistanceCalculator
    {
        double distance(string geocode, string currentgeocode, char unit);
        double deg2rad(double deg);
        double rad2deg(double rad);

    }
}
