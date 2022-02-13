using System.Collections.Generic;
using System;
using BreadTime;
using PastryTime;


namespace TotalCost 
{
  public class OrderTime 
  {
    public double TotalCost { get; set; }

    public OrderTime(double pastryCount, double breadCount)
    {
      TotalCost = pastryCount + breadCount;
    }
  }
}