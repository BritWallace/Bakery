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
      BreadStuff newBreadStuff = new BreadStuff(1);
      Assert.AreEqual(typeof(BreadStuff), newBreadStuff.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateInstancesOfPastry_Pastry()
    {
      PastryStuff newPastryStuff = new PastryStuff(1);
      Assert.AreEqual(typeof(PastryStuff), newPastryStuff.GetType());
    }

    [TestMethod]
    
    public void BreadStuffClass_ChooseAmount_Int()
    {
      int breadCount = 3;
      BreadStuff newBreadStuff = new BreadStuff(breadCount);
      Assert.AreEqual(3, newBreadStuff.Quantity);
  }

  [TestMethod]
    
    public void PastryStuffClass_ChooseAmount_Int()
    {
      int pastryCount = 3;
      PastryStuff newPastryStuff = new PastryStuff(pastryCount);
      Assert.AreEqual(3, newPastryStuff.Quantity);
  }

  [TestMethod]
    
    public void breadStuffClass_ReturnCostOfTwoBread_Int()
    {
      BreadStuff newBreadStuff = new BreadStuff(2);
      double price = 10;
      Assert.AreEqual(2, newBreadStuff.Quantity, price);
  }

    [TestMethod]
    
    public void PastryStuffClass_ReturnCostOfTwoPastry_Int()
    {
      PastryStuff newPastryStuff = new PastryStuff(2);
      double price = 10;
      Assert.AreEqual(2, newPastryStuff.Quantity, price);
  }
  [TestMethod]
    
    public void BreadStuffClass_ReturnCostOfFiveBread_Int()
    {
      BreadStuff newBreadStuff = new BreadStuff(5);
      double price = 20;
      Assert.AreEqual(5, newBreadStuff.Quantity, price);
  }
  [TestMethod]
    
    public void PastryStuffClass_ReturnCostOfFivePastry_Int()
    {
      PastryStuff newPastryStuff = new PastryStuff(5);
      double price = 9;
      Assert.AreEqual(5, newPastryStuff.Quantity, price);
  }
}
}
