using System;
using System.Collections.Generic;
namespace Assignment2 

public class Lot
{
	private int lotNumber = 1000;
	private String description;
	private int currentBid;
	private int bidIncrement;
	private bool sold;
	public Lot()
	{
		lotNumber++;
		description = "Unknown Item";
		currentBid = 0;
		bidIncrement = 0;
		sold = false;

	}
	public Lot(String A, int B, int C)
	{
		lotNumber++;
		description = A;
		currentBid = B;
		bidIncrement = C;
		sold = false;
	}
	public void markSold()
	{
		sold = true;
	}
	public bool getSold()
	{
		return sold;
	}
	public int getBidIn()
	{
		return bidIncrement;
	}
	public String getDes()
	{
		return description;
	}
	public void setBid(int A)
	{
		currentBid = A;
	}
	public int nextBid()
	{
		return currentBid + bidIncrement;
	}
	public override String ToString()
	{
		if (getSold() == true)
		{
			return "Lot " + lotNumber + ". " + description + " was sold for " + currentBid;
		}
		else
		{
			return "Lot " + lotNumber + ". " + description + " current bid " + currentBid + " minimum bid " + nextBid();
		}

	}
	public Lot getNextLot(List<Lot> A)
    {
		Lot tempLot = A;
		A.removeAt(0);
		return tempLot;
    }
	public void addItem(List<Lot> A) 
    {
		String newDes = Console.ReadLine();
		int newBid = int.Parse(Console.ReadLine());
		int newInc = int.Parse(Console.ReadLine());
		A.Add(Lot(newDes, newBid, newInc));
    }
	public void bid(Lot A)
    {
		Console.WriteLine("How much would you like to bid? The current miniumum bid is " + nextBid());
		int bid = int.Parse(Console.ReadLine());
		if (bid < nextBid())
        {
			Console.WriteLine("That bid is too small, you need to up it to " + nextBid());

        } else
        {
			A.setBid(bid);

        }
    }
	public void markSold(Lot A)
    {
		A.markSold();
		Console.WriteLine(A);
    }


}
