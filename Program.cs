using System.Diagnostics;
using LektionAppen.Data;
using static System.Console;

namespace LektionAppen;

class Program
{
  public static void Main()
  {
    Title = "LektionAppen";

    while(true) {
      CursorVisible = false;
      WriteLine("1. Lista Produkter");
      var inputKey = ReadKey(intercept: true);
    
    
    switch (inputKey.Key) {
        case ConsoleKey.D1: 
          ListProducts();
        break;

          case ConsoleKey.D2:
        break;
      }

      Clear();
    }
  }
  private static void ListProducts() {

    using var context = new ApplicationDbContext();
    var products = context.Product.ToList();

    foreach (var product in products) 
    {
      WriteLine($"{product.Id}. {product.Name}. {product.Price}");
    }


    WaitUntilKeyPressed(ConsoleKey.Escape);
  }
  private static void WaitUntilKeyPressed(ConsoleKey key) 
  {
    while(ReadKey(true).Key != ConsoleKey.Escape);
  }
}
