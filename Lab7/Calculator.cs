using System;
namespace Lab7
{
	public class Calculator : CalcOp
	{
		public Calculator()
		{
            
		}
        public int Add(int a, int b)
        {
            Console.Write("These two numbers added equal: ");
            Console.WriteLine(a + b);
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            Console.Write("These two numbers subtracted from each other equal: ");
            Console.WriteLine(a - b);
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            Console.Write("These two numbers multiply to equal: ");
            Console.WriteLine(a * b);
            return a * b;
        }
        public int Divide(int a, int b)
        {
            Console.Write("These two numbers divided equal: ");
            Console.WriteLine(a / b);
            return a / b;
        }
    }
}

