using System;

namespace Bakery.Models
{
public class Program
{
    public static void Main()
    {
      Console.WriteLine("Welcome to Zahnen's Bakery! We sell fresh boules of sourdough ($5.00 per boule) and a rotating daily pastry ($2.00 per pastry). We're running a special on both items. For every two boules you buy, we'll throw in a third for free. For every 2 pastries you buy, we'll offer a third for half off. Enter the number of sourdough boules you'd like to buy:");
      string userBreadQuant = Console.ReadLine();
      int BreadQuant = int.Parse(userBreadQuant);
      Console.WriteLine("Wonderful. Would you like any of our daily pastries? Today we're offering pistachio pinwheels. Enter the number of pinwheels you'd like to buy:");
      string userPastryQuant = Console.ReadLine();
      int PastryQuant = int.Parse(userPastryQuant);
      Bread userBread = new Bread(5, BreadQuant);
      Pastry userPastry = new Pastry (2, PastryQuant);
      int BreadTotal = userBread.GetBreadTotal();
      int PastryTotal = userPastry.GetPastryTotal();
      int GrandTotal = BreadTotal + PastryTotal;
      Console.WriteLine("Sounds good. Your order confirmation is listed below.");
      Console.WriteLine("ZAHNEN'S BAKERY");
      Console.WriteLine("    ------");
      Console.WriteLine("Number of Boules:" + userBreadQuant);
      Console.WriteLine("Number of Pastries:" + userPastryQuant);
      Console.WriteLine("Grand Total: $" + GrandTotal + ".00.");
    }
  }
}