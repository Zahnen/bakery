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
        Bread newBread = new Bread(5, 1);
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }
      [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry newPastry = new Pastry(2);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod]
      public void GetBreadPrice_ReturnsBreadPrice_Int()
      {
        int testBreadPrice = 5;
        Bread newBread = new Bread(testBreadPrice, 2);
        int confirmBreadPrice = newBread.BreadPrice;
        Assert.AreEqual(testBreadPrice, confirmBreadPrice);
      }
      [TestMethod]
      public void GetPastryPrice_ReturnsPastryPrice_Int()
      {
        int testPastryPrice = 2;
        Pastry newPastry = new Pastry(testPastryPrice);
        int confirmPastryPrice = newPastry.PastryPrice;
        Assert.AreEqual(testPastryPrice, confirmPastryPrice);
      }
      [TestMethod]
      public void GetBreadQuantity_ReturnsBreadQuantity_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuant = 1;
        int failBreadQuant = 2;
        Bread newBread = new Bread(testBreadPrice, testBreadQuant);
        int confirmBreadQuant = newBread.BreadQuant;
        Assert.AreEqual(failBreadQuant, confirmBreadQuant);
      }
    }
}