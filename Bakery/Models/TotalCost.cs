using System.Collections.Generic;
using System;
using BreadTime;
using PastryTime;


namespace TotalCost 
{
  public class TotalCost
  {
    public double TotalCost { get; set; }

    public TotalCost(double pastryCount, double breadCount)
    {
      TotalCost = pastryCount + breadCount;
    }
  }
}