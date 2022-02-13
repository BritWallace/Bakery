using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Treats.Logic;
using BreadTime;
using PastryTime;
using System;

namespace Bakery.Tests
{
  
  [TestClass]
  public class BakeryTests 
  {
    [TestMethod]
    public void BreadConstructor_CreateInstancesOfBread_Bread()
    {
      BreadStuff newBreadStuff = new BreadStuff(3);
      Assert.AreEqual(typeof(BreadStuff), newBreadStuff.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateInstancesOfPastry_Pastry()
    {
      PastryStuff newPastryStuff = new PastryStuff(3);
      Assert.AreEqual(typeof(PastryStuff), newPastryStuff.GetType());
    }

    [TestMethod]
    
    public void BreadStuffClass_ChooseAmount_Int()
    {
      int breadCount = 3;
      BreadStuff newBreadStuff = new BreadStuff(breadCount);
      Assert.AreEqual(3, newBreadStuff.Quantity);
  }
}
}
