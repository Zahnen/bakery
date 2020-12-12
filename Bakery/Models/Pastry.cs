using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; }
    public int PastryQuant { get; }
    public int PastryTotalPrice { get; set; }
    public int PastryDiscount { get; set; }
    public int DiscountedPastryTotalPrice { get; set; }
    public int InstancesOfDiscount { get; set; }
    public int BulkDiscount { get; set; }


    public Pastry(int pastryPrice, int pastryQuant)
    {
      PastryPrice = pastryPrice;
      PastryQuant = pastryQuant;
    }

    public int GetPastryTotal()
    {
      PastryTotalPrice = this.PastryPrice * this.PastryQuant;
      if (PastryTotalPrice % 3 == 0)
      {
        PastryDiscount = PastryQuant / 3;
        DiscountedPastryTotalPrice = PastryTotalPrice - PastryDiscount;
        return DiscountedPastryTotalPrice;
      }
      else if (PastryQuant > 3 && PastryTotalPrice % 3 != 0)
      {
        InstancesOfDiscount = PastryQuant / 3;
        BulkDiscount = 1 * InstancesOfDiscount;
        DiscountedPastryTotalPrice = PastryTotalPrice - BulkDiscount;
        return DiscountedPastryTotalPrice;
      }
      else
      {
        return PastryTotalPrice;  
      }
    }
  }
}