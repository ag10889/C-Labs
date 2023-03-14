using System;
public class Recursion2
{
    static string repeatNTimes(int num, string sentence)
    {
        if (num == 0)
        {
            return " ";
        }
        else
        {

            return sentence +  repeatNTimes(num - 1, sentence);
        }
     }
    static string removeAt( string sentence) {
        return sentence.Substring(1, sentence.Length-1);
    }

    static bool isReverse(string A, string B)
    {
        if (A.Length != B.Length)
        {
            return false;
        }
        else if (A == "" && B == "")
        {
            return true;
        }
        else if (A.Length == 1 && B.Length == 1)
        {
            return A[0] == B[0];
        }
        else
        {
            if (A[0] == B[B.Length - 1])
            {
                A = A.Substring(1);
                B = B.Substring(0, B.Length - 1);
                return isReverse(A, B);
            }
            else
            {
                return false;
            }
        }
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(repeatNTimes(4, "Hi"));
        Console.WriteLine(isReverse("Hello", "olleH"));
    }
}

