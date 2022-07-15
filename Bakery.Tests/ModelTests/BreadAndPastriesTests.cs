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
  }
}