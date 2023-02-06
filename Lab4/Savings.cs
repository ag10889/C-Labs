using System;
namespace LAb4
{
	public class Savings : Account
	{
		public Savings()
		{
			accountBal = 0;
		}
		public Savings(double A)
		{
			accountBal = A;
		}
		public double withdrawl(double A)
		{
			if (accountBal - A < 500.00)
			{
				Console.WriteLine("Charging $10 due to an overdraft with $500 or less in the bank");
				return (accountBal -= A -= 10.00);
			} else
			{
				return (accountBal -= A);
			}
		}
		public double deposit(int A)
		{
			int count = 1;
			if (count < 6)
			{
				accountBal += A;
				Console.WriteLine("This is deposit " + count + " to this account");
				count++;
				return accountBal;
			} else
			{
				Console.WriteLine("Charging a $10 depost fee");
				accountBal -= 10;
				accountBal += A;
				return accountBal;
			}
		}
		public double interest()
		{
			double interest = accountBal * 1.5;
			accountBal += interest;
			Console.WriteLine("Your account earned " + interest + " over the year");
			return accountBal;
			
		}
	}
}

