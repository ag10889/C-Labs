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
    static bool isReverse(string A, string B)
    {
        
        return false;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(repeatNTimes(4, "Hi"));
        Console.WriteLine(isReverse("Hello", "olleH"));
    }
}

