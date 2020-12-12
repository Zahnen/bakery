using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuant { get; set; }
    
    public Bread(int breadPrice, int breadQuant)
    {
      BreadPrice = breadPrice;
      BreadQuant = breadQuant;
    }

    public int GetBreadTotal()
    {
      int breadTotalPrice = BreadPrice * BreadQuant;
      if (breadTotalPrice % 3 == 0)
      {
        int breadDiscount = breadTotalPrice / 3;
        int discountedBreadTotalPrice = breadTotalPrice - breadDiscount;
        return discountedBreadTotalPrice;
      }
      else if (BreadQuant > 3 && breadTotalPrice % 3 != 0)
      {
        int instancesOfDiscount = BreadQuant / 3;
        int bulkDiscount = 5 * instancesOfDiscount;
        int discountedBreadTotalPrice = breadTotalPrice - bulkDiscount;
        return discountedBreadTotalPrice;
      }
      else
      {
        return breadTotalPrice;  
      }
    }
  }
}