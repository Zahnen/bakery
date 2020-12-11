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
        Pastry newPastry = new Pastry(2);
        Assert.AreEqual(typeof(Pastry), newPastry.GetType());
      }
      [TestMethod]
      public void GetBreadPrice_ReturnsBreadPrice_Int()
      {
        int testBreadPrice = 5;
        Bread newBread = new Bread(testBreadPrice);
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
    }
}