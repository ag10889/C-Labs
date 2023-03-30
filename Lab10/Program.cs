using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        /* Prompts the user for the file name and stores the name in a string
         */
        Console.Write("Enter the first file name: ");
        string file1 = Console.ReadLine();
        Console.Write("Enter the second file name: ");
        string file2 = Console.ReadLine();
        try
        {
            /* Creates two stremreaders find the file stream to be used in the code
             * Creates four variables, lineNo, different and line1 and 2. lineNo keeps track of the line number
             * different tells the user if the text are different
             * line1 and line2 keep track of each index position in the file
             */
            using (StreamReader reader1 = new StreamReader(file1))
            using (StreamReader reader2 = new StreamReader(file2))
            {
                int lineNo = 1;
                bool different = false;
                string line1,line2;
                /* This while loop assigns line1 and 2 their values from the plain document and makes sure they are not not. 
                 * The if statement compares the contents of each file and increments lineNo if none are found, otherwise it ends the program
                 * if differences are found. This should also check for different line sizes, as one line might have a character
                 * while another line is "null"
                 */
                while ((line1 = reader1.ReadLine()) != null && (line2 = reader2.ReadLine()) != null)
                {
                    if (line1 != line2)
                    {
                        Console.WriteLine($"Line {lineNo}");
                        Console.WriteLine($"< {line1}");
                        Console.WriteLine($"> {line2}");
                        different = true;
                    }
                    lineNo++;
                }
                
                if (!different)
                {
                    Console.WriteLine("Files are the same");
                }
            }
        }
        /* Catch statements starting with IOException before a generalized exception statment to ensure program security
         * and correct handling of errors
         */
        catch (IOException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine("How did we get here? " + e.Message);
        }
        

    }
}