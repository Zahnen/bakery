using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        Bread newBread = new Bread(5);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }
      [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry();
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod]
      public void GetPrice_ReturnsPrice_String()
      {
        int testPrice = 5;
        Bread newBread = new Bread(testPrice);
        int confirmPrice = newBread.BreadPrice;
        Assert.AreEqual(testPrice, confirmPrice);
      }
    }
}