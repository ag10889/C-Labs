using System;
namespace Lab6
{
	public class FibIteration : FindFib
	{
		public int calculate_fib(int n)
		{
			if (n == 0) return 0;
			if (n == 1) return 1;
            return calculate_fib(n - 1) + calculate_fib(n - 2);
        }
		public FibIteration()
		{
		}
	}
}

