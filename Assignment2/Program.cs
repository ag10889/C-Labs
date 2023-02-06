using System;
using System.Collections.Generic;
namespace Assignment2 {
    public class lotTester {
        public Lot getNextLot(List<Lot> A)
        {
            Lot tempLot = A[0];
            if (A[0].getDes().Equals("Unknown Item"))
            {
                return A[0];
            }
            else
            {
                A.Remove(A[0]);
                return tempLot;
            }
        }
        public void addItem(List<Lot> A)
        {
            String newDes = Console.ReadLine();
            int newBid = int.Parse(Console.ReadLine());
            int newInc = int.Parse(Console.ReadLine());
            Lot B = new Lot(newDes, newBid, newInc);
            A.Add(B);
        }
        public void bid(Lot A)
        {
            Console.WriteLine("How much would you like to bid? The current miniumum bid is " + A.nextBid());
            int bid = int.Parse(Console.ReadLine());
            if (bid < A.nextBid())
            {
                Console.WriteLine("That bid is too small, you need to up it to " + A.nextBid());

            }
            else
            {
                A.setBid(bid);

            }
        }
        public void markSold(Lot A)
        {
            A.markSold();
            Console.WriteLine(A);
        }
        public void mainMenu(List<Lot> A)
        {
            Lot currentLot = null;

            int choice;
            do
            {
                Console.WriteLine("1. Add Lot to Auction");
                Console.WriteLine("2. Start bidding on next Lot");
                Console.WriteLine("3. Bid of current Lot");
                Console.WriteLine("4. Mark current Lot sold");
                Console.WriteLine("5. Quit");
                choice = int.Parse(Console.ReadLine());



                if (choice == 1)
                {
                    Console.WriteLine("Enter information about the item you would like to sell");
                    addItem(A);
                    currentLot = A[0];


                }
                else if (choice == 2)
                {
                    if (currentLot == null)
                    {
                        Console.WriteLine("There is nothing to bid on, add an item first");
                    }
                    else
                    {
                        if (currentLot.getSold() != true)
                        {
                            Console.WriteLine("You must sell the previous Lot before proceeding");
                        }
                        else
                        {
                            currentLot = getNextLot(A);
                        }
                    }

                }
                else if (choice == 3)
                {
                    if (currentLot == null)
                    {
                        Console.WriteLine("You must bring up a lot to bid");
                    }
                    else if (currentLot.getDes().Equals("Unknown Item"))
                    {
                        Console.WriteLine("You must bring up an lot to bid on");
                    }
                    else if (currentLot.getSold() == true)
                    {
                        Console.WriteLine("you must bring up a lot to bid on");
                    }
                    else
                    {
                        Console.WriteLine("How much would you like to bid?");
                        int I = int.Parse(Console.ReadLine());
                        currentLot.setBid(I);
                    }

                }
                else if (choice == 4)
                {
                    if (currentLot == null)
                    {
                        Console.WriteLine("You must bring up a lot for sale");
                    }
                    else if (currentLot.getDes().Equals("Unknown Item"))
                    {
                        Console.WriteLine("YOu must bring up a lot for sale");
                    }
                    else
                    {
                        currentLot.markSold();
                    }
                }
            }
            while (choice < 5);


        }
        public static void main(String args)
        {
            List<Lot> Auction = new List<Lot>();
            mainMenu(Auction);
        }
    }
}