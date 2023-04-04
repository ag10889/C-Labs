using System;
using System.Threading;
namespace Lab11;
    public class Baby
    /* Creates a new Baby class
     * Creates two variables, time and name. Sets accessors for them using {get;}
     * Creates a new construction which take in a string, n, and sets name to n
     */
    {
        public int time { get; }
        public string name { get; }
        public Baby(string n)
        {
            name = n;
            Random rand = new Random(); //Creates a new random object, rand
            time = rand.Next(5000); //Rand will be used to set the value of time
        }
        public void Run()
        {
        //Run method is surrounded by try and two catch block
            try
            {
                //WRites the name of the object and the time they will sleep for
                Console.WriteLine("My name is " + name + " I am going to sleep for " + time + "ms");
                Thread.Sleep(time); //Sleeps the thread for time about of time
                Console.WriteLine("My name is " + name + " I am awake, feed me!"); //Wakes the thread and prints statement
    
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("An error has occured " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("A big error has occured" + e);
            }
        }
    public static void Main(string[] args)
    {
        Baby b1 = new Baby("Noah");
        Baby b2 = new Baby("Olivia");
        Baby b3 = new Baby("Liam");
        Baby b4 = new Baby("Emma");
        Baby b5 = new Baby("Amelia");
        Thread t1 = new Thread(b1.Run);
        Thread t2 = new Thread(b2.Run);
        Thread t3 = new Thread(b3.Run);
        Thread t4 = new Thread(b4.Run);
        Thread t5 = new Thread(b5.Run);
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();
    }

}