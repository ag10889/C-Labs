using System;
namespace Lab6 {
    public class Program {
        public static void Main(String[] args)
        {
            Console.WriteLine("Which Fibonacci number would you like to find?");
            int y = int.Parse(Console.ReadLine());
            FibIteration a = new FibIteration();
            FibFormula b = new FibFormula();
            Console.WriteLine(a.calculate_fib(y));
            Console.WriteLine(b.calculate_fib(y));

        }
    }
}
