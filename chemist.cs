using System;

class Chemist {
  static void Main()
  {
    Console.Write("Enter a price per bottle: ");
    string pricePerBottleString = Console.ReadLine();
    int pricePerBottle = int.Parse(pricePerBottleString);

    Console.Write("Enter a tablet count: ");
    string tabletCountString = Console.ReadLine();
    int tabletCount = int.Parse(tabletCountString);

    int bottleCount = ((tabletCount + 99) / 100);
    int salePrice = bottleCount * pricePerBottle;

    Console.WriteLine ( "The number of bottles is " + bottleCount );
    Console.WriteLine( "The total price is " + salePrice );
  }
}
