using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;

public class program
{
    class PersonNotFound : Exception
    {
        public PersonNotFound() : base() { }
        public PersonNotFound(string message) : base(message) { }
        public PersonNotFound(string message, Exception innerException) : base(message, innerException) { }
    }
    public static List<String> getData()
    {
        try
        {
            // Connect to the server
            TcpClient client = new TcpClient("api.coindesk.com", 80); //Socket
            NetworkStream network = client.GetStream(); //Network stream
            StreamWriter writer = new StreamWriter(network); //Stream writer
            StreamReader reader = new StreamReader(client.GetStream()); //stream reader
            writer.WriteLine("GET\nhttp://api.coindesk.com/v1/bpi/currentprice.json HTTP/1.0\\n\\n");
            writer.Flush();
            List<string> respones = new List<string>(); //Creates the list that will be returned
            string netResponse; //Creates the string which will hold values to be entered into the List
            while ((netResponse = reader.ReadLine()) != null)
            {
                respones.Add(netResponse);
            }
            //Closes all the open streams for good practice
            client.Close();
            network.Close();
            writer.Close();
            reader.Close();
            //Returns the List
            return respones;
        }
        catch (IOException e) //Returns an IO exception 
        {
            Console.WriteLine("Error: " + e);
        }
        catch (Exception e) //Returns a general exception
        {
            Console.WriteLine("Error: " + e);
        }
        return null; //Something went wrong
    }
    public static float getDollarPrice(List<string> lines)
    {
        bool header = true;
        String json = "";
        foreach (string line in lines)
        {
            if (line.Equals(""))
            {
                header = false; continue;
            }
            if (header == false)
            {
                json = line;
                break;
            }
        }
        //Console.WriteLine("Json: "+json);
        String[] jsonParts = json.Split(":");
        String priceLine = jsonParts[19];
        String justPrice = priceLine.Replace("},\"GBP\"", ""); float price = Convert.ToSingle(justPrice);
        return price;
    }
    public static void buyBitCoin(float BTC)
    {
        StreamReader sr = new StreamReader("initialInvestmentUSD.txt");
        StreamWriter sw = new StreamWriter("clientBC.txt");
        string person;
        float tempBTC;
        while ((person = sr.ReadLine()) != null)
        {
            person.Split(":", 2);
            tempBTC = Math.Abs(person[1] - BTC);
            sw.WriteLine(person + ":" + tempBTC);
        }
        sr.Close();
        sw.Close();
    }
    public static void getCurrentValue(float BTC)
    {
        StreamReader sr = new StreamReader("clientBC.txt");
        string person;
        float newBTC;
        while ((person = sr.ReadLine()) != null)
        {
            person.Split(":", 2);
            newBTC = person[1] * BTC;
            Console.WriteLine(person + " :" + newBTC);
        }

    }
    public static float getPersonFromFile(string personNam, string fileNam)
    { 
	//This method returns the current value of BTC the person has from the file
        StreamReader sr = new StreamReader(fileNam);
        string corPerson;
        while ((corPerson = sr.ReadLine()) != null)
        {
            corPerson.Split(":",2);
            if (corPerson[0].Equals(personNam))
            {
                return corPerson[1];
            }
            else
            {
                throw new PersonNotFound();
            }
        }
        return 0; //Error detector
    }
    public static void Main(string[] args)
    {
        int checkNum = 0;
        while (checkNum != 4)
        {
            Console.WriteLine(getDollarPrice(getData()));
            float BTC = getDollarPrice(getData());
            Console.WriteLine("1: Buy Bitcoin");
            Console.WriteLine("2: See everyones current value in Bitcoin");
            Console.WriteLine("3: See one person gain/loss");
            Console.WriteLine("4: Quit");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                buyBitCoin(BTC);
            }
            if (input == 2)
            {
                getCurrentValue(BTC);
            }
            if (input == 3)
            {
                Console.WriteLine("Please enter a name.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the file you would like to search.");
                string file = Console.ReadLine();
                float ogInv = getPersonFromFile(name, file);
		float currentValue = ogInv * getCurrentValue(BTC); //Somehow get the current value
		float change = currentValue - ogInv;
		Console.writeLine(change);
		
            }
        }
    }
}