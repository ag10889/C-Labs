using System;
namespace assignment5
{
    public class assignment5
    {
        static string reverse(string A)
        {
            char [] a = A.ToCharArray();
            for (int i = 0; i < A.Length-1; i++)
            {
                char initial = A[i];
                char replaced = A[A.Length - (i + 1)];
                a[i] = replaced;
                a[A.Length - (i + 1)] = initial;
            }
            string B = new string(a);
            return B;
        }
        static string reverseTwo(string A)
        {
          
            if (A == "" || A.Length == 1)
            {
                return A;
            }
            
            else
            {
                return reverseTwo(A.Substring(1)) + A[0];
            }
        }
        static string helperFlip(string A)
        {
            A = A.Replace('^', '#');
            A = A.Replace('v', '^');
            A = A.Replace('#', 'v');

            return A;
        }
        static string paperFold(int n)
        {
            if (n == 1)
            {
                return "";
            }
            else
            {
                return paperFold(n - 1);
            }
        }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(reverse("Hello"));
            Console.WriteLine(reverseTwo("Hello"));
            Console.WriteLine(helperFlip("v^v^vvv"));
            Console.WriteLine(paperFold(3));
        }
    }
    
}

