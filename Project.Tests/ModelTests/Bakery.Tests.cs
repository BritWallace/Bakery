using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Treats.Logic;
using BreadTime;
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
  }
}
