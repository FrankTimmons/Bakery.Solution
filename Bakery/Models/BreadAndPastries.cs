using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }
    public int Price { get; set; }

    public Bread(int amount)
    {
      BreadAmount = amount;
    }

    public void BreadPriceCalc()
    {
      Price = BreadAmount * 5;
      if (BreadAmount % 3 == 0)
      {
        Price -= (Price / 3); 
      }
    }
  }

  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int Price { get; set; }

    public Pastry(int amount)
    {
      PastryAmount = amount;
    }

    public void PastryPriceCalc()
    {
      Price = PastryAmount * 2;
    }
  }
}