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
      else
      {
        return BreadTotalPrice;  
      }
    }
  }
  public class Pastry
  {
    public int PastryPrice { get; }
    public int PastryQuant { get; }
    public int PastryTotalPrice { get; set; }
    public int PastryDiscount { get; set; }
    public int DiscountedPastryTotalPrice { get; set; }
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
      else
      {
        return PastryTotalPrice;  
      }
    }
  }
}

    // public int AddBreadTotal()
    // {
    //   if (DiscountedBreadTotalPrice > 0)
    //   {
    //     Order.GrandTotal.Add(DiscountedBreadTotalPrice);
    //   }
    //   else if (BreadTotalPrice > 0)
    //   {
    //     Order.GrandTotal.Add(BreadTotalPrice);
    //   }
    //   else
    //   {
    //     Order.GrandTotal.Add(0);
    //   }
    // }