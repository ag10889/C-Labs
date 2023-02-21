using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public interface CalcOp
    {
        public int add();
        public int subtract();
        public int multiply();
        public int divide();

    }
    class Calculator : CalcOp
    {
        public Calculator()
        {

        }
        public override int add(int a, int b)
        {
            Console.WriteLine("These two numbers added equal: ");
            return a + b;
        }
        public override int subtract(int a, int b)
        {
            Console.WriteLine("These two numbers subtracted from each other equal: ");
            return a - b;
        }
        public override int multiply(int a, int b)
        {
            Console.WriteLine("These two numbers multiply to equal: ");
            return a * b;
        }
        public override int divide(int a, int b)
        {
            Console.WriteLine("These two numbers divided equal: ");
            return a / b;
        }
    }
    class Program
    {
        Calculator calc = new Calculator();
        public static void Main(String[] args)
        {
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
                    calc.add(I, A);

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Please enter the two numbers you would like to subtract");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.subtract(I, A);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Please enter the two numbers you would like to multiply");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.multiply(I, A);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Please enter the two numbers you would like to divide");
                    int I = int.Parse(Console.ReadLine());
                    int A = int.Parse(Console.ReadLine());
                    calc.divide(I, A);
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
