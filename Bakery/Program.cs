using System;
using System.Collections.Generic;
using Bakery.Models;4

namespace Bakery
{
  public class Program
  {
    public int Pastries { get; set; }
    public int Loaves { get; set; } 

    static void Main()
    {
      WelcomeMessage();
      Prompt();
      GetPrice();
    }

    static void WelcomeMessage()
    {
      Console.WriteLine("PIERRE'S BAKERY");
      Console.WriteLine("---------------");
      Console.WriteLine("Welcome to Pierre's!");
    }

    static void Prompt()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string stringLoaves = Console.ReadLine();
      Loaves = int.Parse(stringLoaves);
      Console.WriteLine("How many pastries would you like?");
      string stringPastries = Console.ReadLine();
      Pastries = int.Parse(stringPastries);
    }

    static void GetPrice(int loaves, int pastries)
    {
      Bread newBreadOrder = new Bread(loaves);
      newBreadOrder.BreadPriceCalc();
      Pastry newPastryOrder = new Pastry(pastries);
      newPastryOrder.PastryPriceCalc();
      int totalPrice = newBreadOrder.Price + newPastryOrder.Price;
      Console.WriteLine("Your total price is: $" + totalPrice);
    }
  }
}