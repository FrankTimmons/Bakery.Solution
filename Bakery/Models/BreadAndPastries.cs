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
      
    }
  }
}