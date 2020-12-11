namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; }
    public int BreadQuant { get; }
    public Bread(int breadPrice, int breadQuant)
    {
      BreadPrice = breadPrice;
      BreadQuant = breadQuant;
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