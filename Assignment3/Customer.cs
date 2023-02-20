using System;
namespace Assignment3
{
	public abstract class Customer
	{
		private char letter;
		private int number;
		private static int intA = 0;
		private static int intB = 0;
		private static int intC = 0;
		private static int intD = 0;

		public Customer()
		{
			letter = 'x';
			number = 0;
			//Used for error shooting
		}
		public Customer(char x)
		{
			if (x.Equals("A"))
			{
				letter = x;
				intA++;
			} else if (x.Equals("B"))
			{
				letter = x;
				intB++;
			} else if (x.Equals("C"))
			{
				letter = x;
				intC++;
			} else if (x.Equals("D"))
			{
				letter = x;
				intD++;
			}
			else
			{
				letter = 'X';
				Console.WriteLine("Letter can only be A, B, C or D");
			}
		}
		protected string getTicketNumber()
		{
			return string.Concat(letter + number);
		}
		public abstract string getCustomerInfo();


	}
}

