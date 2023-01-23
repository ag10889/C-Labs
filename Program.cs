using System;

namespace lab2;
class Program
{

    static void Main(string[] args)
    {

        StockItem milk = new StockItem("1 Gallon of Milk", 3.60, 15);
        StockItem bread = new StockItem("1 Loaf of Bread", 1.98, 30);
        int choice;
        do
        {
            Console.WriteLine("1. Sold One Milk");
            Console.WriteLine("2. Sold One Bread");
            Console.WriteLine("3. Change Price of Milk");
            Console.WriteLine("4. Change Price of Bread");
            Console.WriteLine("5. Add Milk to Inventory");
            Console.WriteLine("6. Add Bread to Inventory");
            Console.WriteLine("7. See Inventory");
            Console.WriteLine("8. Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                milk.lowQuantity(1);
                
            } else if(choice == 2)
            {
                bread.lowQuantity(1);
            } else if(choice == 3)
            {
                Console.WriteLine("Enter new Price of milk below:");
                double sale = double.Parse(Console.ReadLine());
                milk.newPrice(sale);
            } else if (choice == 4)
            {
                Console.WriteLine("Enter new Price of bread below:");
                double sale = double.Parse(Console.ReadLine());
                milk.newPrice(sale);
            } else if (choice == 5) {
                Console.WriteLine("Enter the shipment of milk recieved below:");
                int shipment = int.Parse(Console.ReadLine());
                milk.addQuantity(shipment);
            } else if (choice == 6)
            {
                Console.WriteLine("Enter the shipment of bread recieved below:");
                int shipment = int.Parse(Console.ReadLine());
                bread.addQuantity(shipment);
            } else if (choice == 7)
            {
                Console.WriteLine("milk" + milk);
                Console.WriteLine("bread" + bread);
            } else if (choice > 8)
            {
                Console.WriteLine("Enter valid operation");
            } 
            
        }
        while (choice != 8);
        
    }
}


    