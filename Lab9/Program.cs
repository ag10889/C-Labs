using System;

class Program
{
    class InvalidTimeException : Exception
    {
        /* Creates a new Exception class called InvalidTimeException. 
         * Creates a new default Exception constructor of type InvalidTimeException
         * Creates a new overloaded Exception constructor of type InvalidTimeException
         * Creates a new overloaded Exception constructor of type InvalidTimeException that inherits its message and 
         */
        public InvalidTimeException() : base() { } 
        public InvalidTimeException(string message) : base(message) { }  
        public InvalidTimeException(string message, Exception innerException) : base(message, innerException) { }  
    }
    public static int ConvertTimeToSeconds(string timeString)
    {
        /* Creates a new method, ConvertTimeToSecond, which takes a string, timeString, and returns an int
         * Creates a new string array, parts, which takes in the values split by timeString.Split(':',3).
         * int hours, minutes and seconds each are given their represtive values after converting the indexes to Int32
         * Inside the if statements, hours, minutes and seconds are checked for validaty 
         * Returns (hours * 60 * 60) + (minutes * 60) + seconds
         */
        string[] parts = timeString.Split(':', 3);
        if (timeString.Length != 8)
        {
            throw new InvalidTimeException("Invalid time format has been entered.");
        }
        int hours, minutes, seconds;
        if (!int.TryParse(parts[0], out hours) || !int.TryParse(parts[1], out minutes) || !int.TryParse(parts[2], out seconds))
        {
            throw new InvalidTimeException("Invalid time format has been entered, please enter numerical values. ");
        }
    
        if (hours == null || hours < 0 || hours > 23)
        {
            throw new InvalidTimeException("Hours must be less than 24: " + hours);
        }

        if (minutes == null || minutes < 0 || minutes > 59)
        {
            throw new InvalidTimeException("Minutes must be less than 60: " + minutes);
        }

        if (seconds == null || seconds < 0 || seconds > 59)
        {
            throw new InvalidTimeException("Seconds must be less than 60: " + seconds);
        }
        

        return (hours * 60 * 60) + (minutes * 60) + seconds;
        
    }

    static void Main(string[] args)
    {
        /*Runs the code in a try catch block, with InvalidTimeException catching incorrect HH,MM,SS or invalid inputs
         * 
         */
        try
        {
            Console.Write("Enter the first time (in HH:MM:SS format): ");
            string firstTime = Console.ReadLine();
            int firstSeconds = ConvertTimeToSeconds(firstTime);

            Console.Write("Enter the second time (in HH:MM:SS format): ");
            string secondTime = Console.ReadLine();
            int secondSeconds = ConvertTimeToSeconds(secondTime);

            int difference = secondSeconds - firstSeconds;
            Console.WriteLine("The difference between the two times is {0} seconds.", difference);
        }
        catch (InvalidTimeException ex)
        {
            Console.WriteLine("Invalid time entered: {0}", ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

