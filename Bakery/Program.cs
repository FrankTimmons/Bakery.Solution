using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("PIERRE'S BAKERY");
      Console.WriteLine("---------------");
      Console.WriteLine("Welcome to Pierre's!");
      Prompt();
    }

    static void Prompt()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string stringLoaves = Console.ReadLine();
      int loaves = int.Parse(stringLoaves);
      Console.WriteLine("How many pastries would you like?");
      string stringPastries = Console.ReadLine();
      int pastries = int.Parse(stringPastries);
      GetPrice(loaves, pastries);
    }

    static void GetPrice(int loaves, int pastries)
    {
      Bread newBreadOrder = new Bread(loaves);
      newBreadOrder.BreadPriceCalc();
      Pastry newPastryOrder = new Pastry(pastries);
      newPastryOrder.PastryPriceCalc();
      int totalPrice = newBreadOrder.Price + newPastryOrder.Price;
      Console.WriteLine("Your total price is: " + totalPrice);
    }
  }
}