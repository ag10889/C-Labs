public class Driver {
    static int recursive_multiple(int mulitplicand, int multiplier)
    {
        if (mulitplicand == 1 || multiplier == 1)
        {
            return mulitplicand * multiplier;
        }
        else if (mulitplicand == 0 || multiplier == 0)
        {
            return 0;
        }
        else
        {
            return mulitplicand + recursive_multiple(mulitplicand, multiplier - 1);
        }
    }
    static int recursive_div(int dividend, int divisor)
    {
        int count = 0;
        if (dividend == divisor || divisor == dividend)
        {
            return 1;
        }
        else if (dividend == 0 || divisor == 0)
        {
            return -1;
        }
        else if (divisor > dividend)
        {
            return 0;
        }
        else
        {
            count++;
            return count + recursive_div(dividend - divisor, divisor);
        }
    }
    static int recursive_mod(int information, int RF)
    {
        if (information == 0 || RF == 0)
        {
            return -1;
        }
        else if (information < RF)
        {
            return information;
        }
        else
        {
            return recursive_mod(information - RF, RF);
        }
    }
    public static void Main(String[] args)
    {
        int end = 4;
        while (end != 0)
        {
            Console.WriteLine("0. Quit:");
            Console.WriteLine("1. Multiply 2 numbers");
            Console.WriteLine("2. Divide 2 numbers");
            Console.WriteLine("3. Mod 2 numbers");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the multiplicand ");
                int multiplicand = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the multiplier ");
                int multiplier = int.Parse(Console.ReadLine());
                Console.WriteLine(recursive_multiple(multiplicand, multiplier));

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the dividend ");
                int divdiend = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the divisor ");
                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine(recursive_multiple(divdiend, divisor));

            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter number 1 ");
                int information = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number ");
                int RF = int.Parse(Console.ReadLine());
                Console.WriteLine(recursive_multiple(information, RF));

            }
            else if (choice == 4 || choice > 4)
            {
                Console.WriteLine("Please enter valid operation. ");
            }
            else
            {
                end = 0;
            }
        }
    }
}