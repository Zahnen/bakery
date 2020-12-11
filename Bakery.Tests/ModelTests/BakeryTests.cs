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
        Bread newBread = new Bread();
        string failBread = "This should confirm a string is not the same data type as a Bread Object";
        Assert.AreEqual(typeof(Bread), failBread.GetType());
      }
    }
}