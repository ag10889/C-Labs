using System;
namespace Lab6
{
	public class FibFormula : FindFib
	{
		public int calculate_fib(int n)
		{
            double phi = (1 + Math.Sqrt(5)) / 2;
            double psi = (1 - Math.Sqrt(5)) / 2;
            double Fn = (Math.Pow(phi, n) - Math.Pow(psi, n)) / Math.Sqrt(5);
            return (int)Fn;
        }
		public FibFormula()
		{
		}
	}
}

