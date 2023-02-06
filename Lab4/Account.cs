using System;
namespace LAb4
{
	public class Account
	{
		public int accountNum { get; }
		public double accountBal { get; set; }

		public Account()
		{
			accountBal = 0;
		}
		public Account(double A)
		{
			accountBal = A;
		}
		public double withdrawl(double A)
		{
			return (accountBal - A);
		}
		public double deposit(double A)
		{
			return (accountBal + A);
		}
	}
}

