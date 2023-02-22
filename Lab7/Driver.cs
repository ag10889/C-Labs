using System;
namespace Lab7 {

    class Program
    {
        public static void Main(String[] args)
        {
            Calculator calc = new Calculator();
            int choice;
            do
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please enter the two numbers you would like to add");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.Add(I, A);

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please enter the two numbers you would like to subtract");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.Subtract(I, A);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Please enter the two numbers you would like to multiply");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.Multiply(I, A);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Please enter the two numbers you would like to divide");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.Divide(I, A);
                }
                else if (choice > 4)
                {
                    Console.WriteLine("Enter valid operation");
                }

            }
            while (choice != 0);
        }
    }
}