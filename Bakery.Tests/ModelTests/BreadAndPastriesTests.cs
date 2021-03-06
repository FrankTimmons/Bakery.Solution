using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_MakeAnInstanceOfBreadWithAnAmount_Int()
    {
      Bread newBreadOrder = new Bread(5);
      Assert.AreEqual(5, newBreadOrder.BreadAmount);
    }

    [TestMethod]
    public void BreadPriceCalc_MakeBreadCostFiveDollars_Int()
    {
      Bread newBreadOrder = new Bread(1);
      newBreadOrder.BreadPriceCalc();
      Assert.AreEqual(5, newBreadOrder.Price);
    }

    [TestMethod]
    public void BreadPriceCalc_MakeEveryThirdBreadFree_Int()
    {
      Bread newBreadOrder = new Bread(3);
      newBreadOrder.BreadPriceCalc();
      Assert.AreEqual(10, newBreadOrder.Price);
    }
  }
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_MakeAnInstanceOfPastryWithAnAmount_Int()
    {
      Pastry newPastryOrder = new Pastry(5);
      Assert.AreEqual(5, newPastryOrder.PastryAmount);
    }

    [TestMethod]
    public void PastryPriceCalc_MakePastriesCostTwoDollars_Int()
    {
      Pastry newPastryOrder = new Pastry(1);
      newPastryOrder.PastryPriceCalc();
      Assert.AreEqual(2, newPastryOrder.Price);
    }

    [TestMethod]
    public void PastryPriceCalc_MakeEveryThirdPastryHalfOff_Int()
    {
      Pastry newPastryOrder = new Pastry(3);
      newPastryOrder.PastryPriceCalc();
      Assert.AreEqual(5, newPastryOrder.Price);
    }
  }
}