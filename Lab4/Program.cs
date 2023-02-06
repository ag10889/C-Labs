using System;

namespace LAb4;
class Program
{

    static void Main(string[] args)
    {

        Checking Checking = new Checking();
        Savings Saving = new Savings();
        int choice;
        do
        {
            Console.WriteLine("1. Withdrawl from checking");
            Console.WriteLine("2. Withdrawl from savings");
            Console.WriteLine("3. Deposit to checking");
            Console.WriteLine("4. Deposit to savings");
            Console.WriteLine("5. Check balance of checking");
            Console.WriteLine("6. Check balance of savings");
            Console.WriteLine("7. Appky earned interest");
            Console.WriteLine("8. Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter how much you would like to withdrawl");
                double I = double.Parse(Console.ReadLine());
                Checking.withdrawl(I);

            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter how much you would like to withdrawl");
                double I = double.Parse(Console.ReadLine());
                Saving.withdrawl(I);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter how much you would like to deposit");
                double I = double.Parse(Console.ReadLine());
                Checking.deposit(I);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter how much you would like to deposit");
                double I = double.Parse(Console.ReadLine());
                Saving.deposit(I);
            }
            else if (choice == 5)
            {
                Console.WriteLine(Checking.accountBal);
            }
            else if (choice == 6)
            {
                Console.WriteLine(Saving.accountBal);
            }
            else if (choice == 7)
            {
                Console.WriteLine(Saving.interest());
            }
            else if (choice > 8)
            {
                Console.WriteLine("Enter valid operation");
            }

        }
        while (choice != 8);

    }
}


