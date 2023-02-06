using System;
namespace LAb4
{
	public class Checking : Account 
	{
		public Checking()
		{
			accountBal = 0;
		}
		public Checking(double A)
		{
			accountBal = A;
		}
		public int withdrawl(int A)
		{
			if (accountBal - A < 0)
			{
				Console.WriteLine("Charging an overdraft fee of $20 due to $0 in balance");
				return (int)(accountBal - 20);
			} else
			{
				return (int)(accountBal - A);
			}
		}
	}
}

