using System;

class Program
{
    public class InvalidTimeException : Exception
    {
        public InvalidTimeException() : base() { } //creates a new exception type named InvalidTimeExxception
        public InvalidTimeException(string message) : base(message) { } //InvalidTimeException has the same "error" message as exception as it inherits it
        public InvalidTimeException(string message, Exception innerException) : base(message, innerException) { } //Inherits 
    }
    public static int ConvertTimeToSeconds(string timeString)
    {
        string[] parts = timeString.Split(':', 3);

        int hours = Convert.ToInt32(parts[0]);
        int minutes = Convert.ToInt32(parts[1]);
        int seconds = Convert.ToInt32(parts[2]);

        if (hours < 0 || hours > 23)
        {
            throw new InvalidTimeException("Invalid hour value: " + hours);
        }

        if (minutes < 0 || minutes > 59)
        {
            throw new InvalidTimeException("Invalid minute value: " + minutes);
        }

        if (seconds < 0 || seconds > 59)
        {
            throw new InvalidTimeException("Invalid second value: " + seconds);
        }

        int totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
        return totalSeconds;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the first time (in HH:MM:SS format): ");
            string firstTime = Console.ReadLine();
            int firstSeconds = ConvertTimeToSeconds(firstTime);

            Console.Write("Enter the second time (in HH:MM:SS format): ");
            string secondTime = Console.ReadLine();
            int secondSeconds = ConvertTimeToSeconds(secondTime);

            int difference = firstSeconds - secondSeconds;
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

