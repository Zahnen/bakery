using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; }
    public int PastryQuant { get; }

    public Pastry(int pastryPrice, int pastryQuant)
    {
      PastryPrice = pastryPrice;
      PastryQuant = pastryQuant;
    }

    public int GetPastryTotal()
    {
      int pastryTotalPrice = PastryPrice * PastryQuant;
      if (pastryTotalPrice % 3 == 0)
      {
        int pastryDiscount = PastryQuant / 3;
        int discountedPastryTotalPrice = pastryTotalPrice - pastryDiscount;
        return discountedPastryTotalPrice;
      }
      else if (PastryQuant > 3 && pastryTotalPrice % 3 != 0)
      {
        int instancesOfDiscount = PastryQuant / 3;
        int bulkDiscount = 1 * instancesOfDiscount;
        int discountedPastryTotalPrice = pastryTotalPrice - bulkDiscount;
        return discountedPastryTotalPrice;
      }
      else
      {
        return pastryTotalPrice;  
      }
    }
  }
}