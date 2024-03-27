using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Container gasContainer = new Gas(10, 5, 100, 200, "Propane", true);
            Container liquidContainer = new Liquid(8, 4, 80, 150, "Water", false);
            Container cooledContainer = new Cooled(12, 6, 120, 250, "Vegetables", 4);

            Ship ship = new Ship(20, 10, 1000);

            ship.AddContainer(gasContainer);
            ship.AddContainer(liquidContainer);
            ship.AddContainer(cooledContainer);

            Console.WriteLine(ship.ToString());

            ship.RemoveContainer(gasContainer);

            Console.WriteLine(ship.ToString());

            Container newCooledContainer = new Cooled(15, 7, 150, 300, "Fruits", 5);
            ship.ReplaceContainer(newCooledContainer, cooledContainer.GetCount());

            Console.WriteLine(ship.ToString());

            Ship anotherShip = new Ship(25, 15, 1200);
            ship.tradeContainer(liquidContainer, anotherShip);

            Console.WriteLine("Ship 1: " + ship);
            Console.WriteLine("Ship 2: " + anotherShip);
        }
    }
}