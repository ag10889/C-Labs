using System;
using System.Collections.Generic;
namespace Assignment2
{


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
                return "Lot " + lotNumber + ". " + getDes() + " was sold for " + currentBid;
            }
            else
            {
                return "Lot " + lotNumber + ". " + getDes() + " current bid " + currentBid + " minimum bid " + nextBid();
            }

        }
       

    }
}
