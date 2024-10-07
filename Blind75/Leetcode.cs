class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        for (int i = 1; i < n; i++){
        if ((i % 5) == 0) {
            Console.WriteLine("Buzz");
        }
        else if ((i % 3) == 0){
            Console.WriteLine("Fizz");
        }
        else if((i % 3 == 0 && i % 5 == 0)){
            Console.WriteLine("FizzBuzz");
        }
        else{
            Console.WriteLine(i);
        }
        }
    }
}
ass Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}