using System;
using Bakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Zahnen's Bakery! We sell fresh boules of sourdough and a rotating daily pastry. Enter the number of boules you'd like to buy now:");
    string userBreadQuant = Console.ReadLine();
    int BreadQuant = int.Parse(userBreadQuant);
    Console.WriteLine("Wonderful. Would you like any of our daily pastries? Today we're offering pistachio pinwheels. Enter the number of pinwheels you'd like to buy now");
    string userPastryQuant = Console.ReadLine();
    int PastryQuant = int.Parse(userPastryQuant);
    Bread userBread = new Bread(5, BreadQuant);
    Pastry userPastry = new Pastry (2, PastryQuant);
    int BreadTotal = userBread.GetBreadTotal();
    int PastryTotal = userPastry.GetPastryTotal();
    int GrandTotal = BreadTotal + PastryTotal;
    Console.WriteLine("Sounds good. Your order confirmation is listed below.");
    Console.WriteLine("ZAHNEN'S BAKERY");
    Console.WriteLine("-----");
    Console.WriteLine("Number of Boules:" + userBreadQuant);
    Console.WriteLine("Number of Pastries:" + userPastryQuant);
    Console.WriteLine("Grand Total: $" + GrandTotal + ".00.");
  }
}