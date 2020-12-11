namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; }
    public Bread(int breadPrice)
    {
      BreadPrice = breadPrice;
    }
  }
  public class Pastry
  {
    public int PastryPrice { get; }
    public Pastry(int pastryPrice)
    {
      PastryPrice = pastryPrice;
    }
  }
}