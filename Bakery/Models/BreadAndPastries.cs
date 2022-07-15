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
      for(int i = 1; i <= BreadAmount; i++)
      {
        if (i % 3 == 0)
        {
          Price += 0;
        }
        else
        {
          Price += 5;
        }
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
      for(int i = 1; i <= PastryAmount; i++)
      {
        if (i % 3 == 0)
        {
          Price += 1;
        }
        else
        {
          Price += 2;
        }
      }
    }
  }
}