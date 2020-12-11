using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

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
        Pastry newPastry = new Pastry(2, 1);
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
        Pastry newPastry = new Pastry(testPastryPrice, 1);
        int confirmPastryPrice = newPastry.PastryPrice;
        Assert.AreEqual(testPastryPrice, confirmPastryPrice);
      }
      [TestMethod]
      public void GetBreadQuantity_ReturnsBreadQuantity_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuant = 1;
        Bread newBread = new Bread(testBreadPrice, testBreadQuant);
        int confirmBreadQuant = newBread.BreadQuant;
        Assert.AreEqual(testBreadQuant, confirmBreadQuant);
      }
      [TestMethod]
      public void GetPastryQuantity_ReturnsPastryQuantity_Int()
      {
        int testPastryPrice = 2;
        int testPastryQuant = 1;
        Pastry newPastry = new Pastry(testPastryPrice, testPastryQuant);
        int confirmPastryQuant = newPastry.PastryQuant;
        Assert.AreEqual(testPastryQuant, confirmPastryQuant);
      }
      [TestMethod]
      public void GetBreadTotalPrice_ReturnsBreadTotalPrice_Int()
      {
        int testBreadPrice = 5;
        int testBreadQuant = 3;
        int testBreadTotalPrice = 10;
        Bread newBread = new Bread(testBreadPrice, testBreadQuant);
        int confirmBreadTotalPrice = newBread.GetBreadTotal();
        Assert.AreEqual(testBreadTotalPrice, confirmBreadTotalPrice);
      }
      [TestMethod]
      public void GetPastryTotalPrice_ReturnsPastryTotalPrice_Int()
      {
        int testPastryPrice = 2;
        int testPastryQuant = 3;
        int testPastryTotalPrice = 5;
        Pastry newPastry = new Pastry(testPastryPrice, testPastryQuant);
        int confirmPastryTotalPrice = newPastry.GetPastryTotal();
        Assert.AreEqual(testPastryTotalPrice, confirmPastryTotalPrice);
      }
      [TestMethod]
      public void GetGrandTotal_ReturnsOrderTotalPriceinList_List()
      {
        List<int> GrandTotal = new List<int> {};
        Bread newBread = new Bread(5, 3);
        Assert.AreEqual(GrandTotal[0], newBread.addPrice(newBread.GetBreadTotal()));
      }
    }
}