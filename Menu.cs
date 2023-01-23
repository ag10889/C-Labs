using System;
namespace lab2
{
    class StockItem
    {
        private String description;
        static int serial;
        private int ID;
        private double price;
        private int quantity;

        public StockItem()
        {
            description = "";
            ID = 0;
            price = 0.00;
            quantity = 0;
            ID =+ serial++;
        } //default

        public StockItem(String desc, double sale, int quantity)
        {
            ID = serial++;
            description = desc;
            price = sale;
            this.quantity = quantity;
            

        } //overloaded

        public override String ToString()
        {
            return  ": Item number: " + ID + " is " + description + " has price of " + price + " we currently have " + quantity;
        }
        // Accessors follow
        public String getD()
        {
            return description;
        }
        public int getID()
        {
            return ID;
        }
        public double getPrice()
        {
            return price;
        }
        public int getQuantity()
        {
            return quantity;
        }
        // Mutators follow
        public double newPrice(double a)
        {
            if (a >= 0.00)
            {
                price = a;
                return price;
            }
            else
            {
                Console.Write("Error");
                return price;
            }

        }
        public int lowQuantity(int a)
        {
            if (quantity - a >= 0)
            {
                quantity -= a;
                return quantity;
            }
            else
            {
                Console.Write("Error");
                return quantity;
            }
        }
        public int addQuantity(int a)
        {
            quantity += a;
            return quantity;
        }
    }

}

