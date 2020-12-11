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
    public Pastry(int pastryPrice, int pastryQuant)
    {
      PastryPrice = pastryPrice;
      PastryQuant = pastryQuant;
    }
  }
}