using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuant { get; set; }
    public int BreadTotalPrice { get; set; }
    public int BreadDiscount { get; set; }
    public int DiscountedBreadTotalPrice { get; set; }
    public int BulkDiscount { get; set; }
    public int InstancesOfDiscount { get; set; }

    public Bread(int breadPrice, int breadQuant)
    {
      BreadPrice = breadPrice;
      BreadQuant = breadQuant;
    }

    public int GetBreadTotal()
    {
      BreadTotalPrice = this.BreadPrice * this.BreadQuant;
      if (BreadTotalPrice % 3 == 0)
      {
        BreadDiscount = BreadTotalPrice / 3;
        DiscountedBreadTotalPrice = BreadTotalPrice - BreadDiscount;
        return DiscountedBreadTotalPrice;
      }
      else if (BreadQuant > 3 && BreadTotalPrice % 3 != 0)
      {
        InstancesOfDiscount = BreadQuant / 3;
        BulkDiscount = 5 * InstancesOfDiscount;
        DiscountedBreadTotalPrice = BreadTotalPrice - BulkDiscount;
        return DiscountedBreadTotalPrice;
      }
      else
      {
        return BreadTotalPrice;  
      }
    }
  }
}