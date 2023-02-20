using System;
namespace Assignment3
{
    public class driver
    {
           
            public static void Menu(List<Customer> customers)
            {
            int end = 0;
                while (end != 6)
                {
                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Assign to Area A");
                    Console.WriteLine("2. Assign to Area B");
                    Console.WriteLine("3. Assign to Area C");
                    Console.WriteLine("4. Assign to Area D");
                    Console.WriteLine("5. Print all customers");
                    Console.WriteLine("6. Quit");

                    int choice = int.Parse(Console.ReadLine());

                    if(choice == 1)
                {
                    Console.WriteLine("Enter name:");
                    string nameA = Console.ReadLine();
                    Console.WriteLine("Enter date of birth:");
                    string dobA = Console.ReadLine();
                    customers.Add(new NewTest(nameA, dobA));
                    Console.WriteLine("Customer added to Area A.");
                       
                } else if(choice == 2)
                {
                            Console.WriteLine("Enter name:");
                    string nameB = Console.ReadLine();
                    Console.WriteLine("Enter violation:");
                    string violationB = Console.ReadLine();
                    customers.Add(new Renew(nameB));
                    Console.WriteLine("Customer added to Area B.");
                } else if(choice == 3)
                {
                            Console.WriteLine("Enter name:");
                    string nameC = Console.ReadLine();
                    Console.WriteLine("Enter state:");
                    string stateC = Console.ReadLine();
                    customers.Add(new Move(nameC, stateC));
                    Console.WriteLine("Customer added to Area C.");   
                } else if(choice == 4)
                {
                            Console.WriteLine("Enter name:");
                    string nameD = Console.ReadLine();
                    Console.WriteLine("Enter violation:");
                    string violationD = Console.ReadLine();
                    customers.Add(new Suspended(nameD, violationD));
                    Console.WriteLine("Customer added to Area D.");
                } else if(choice == 5)
                {
                            Console.WriteLine("All customers:");
                    foreach (Customer c in customers)
                    {
                        Console.WriteLine(c.getCustomerInfo());
                    }
                } else if(choice == 6)
                {
                    end = 6;
                } else
                {
                   
                    Console.WriteLine("Invalid option.");
                }
                }
            }
        public static void Main(string[] args)
        {
            driver A = new driver();
            List<Customer> customers = new List<Customer>();
            driver.Menu(customers);
        }
    }
}