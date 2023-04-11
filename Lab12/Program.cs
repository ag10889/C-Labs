public class BlueRayDisk
{
    public string title;
    public string director;
    public int YearOfRelease;
    public double cost;
    public BlueRayDisk(string t, string d, int y, double c)
    {
        title = t;
        director = d;
        YearOfRelease = y;
        cost = c;
    }
    public override string ToString()
    {
        return "$" + cost + " " + YearOfRelease + " " + title + ", " + director;
    }
    
}
public class Node
{
    /* Creates a new Node class which creates two data types. Data of type BlueRayDisk and Next of type Node. 
     * Creates a Node constructor which takes in a BlueRayDisk. 
     * Sets data = disk and next = null
     */
    public BlueRayDisk data;
    public Node next;
    public Node(BlueRayDisk disk)
    {
        data = disk;
        next = null;
    }
}
public class BlueRayCollection
{
    private Node head = null; //Creates new node
    public void add(string t, string d, int y, double c)
    {
        BlueRayDisk newDisk = new BlueRayDisk(t, d, y, c); //Creates new BlueRay Object to be used later
        Node newNode = new Node(newDisk); //Creates new Node of the newDisk object 
        if (head == null) /* Assigns teh head the newNode value
                           */
        {
            head = newNode;
        } else /* Traverses the linkedList for the tail if head is not null
                * Assigns the tail value to newNode value
                */ 
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }
    public void show_all()
    {
        Node current = head; //Sets current to first Node
        while (current != null) /* Iterates through the LinkedList making sure no values are null and printing their data
                                 */
        {
            Console.WriteLine(current.data.ToString());
            current = current.next;
        }

    }
}
public class program {
    public static void Main(string[] args)
    {
        int choice = 3;
        BlueRayCollection collection = new BlueRayCollection();
        while (choice != 0)
        {
            Console.WriteLine("0: Quit");
            Console.WriteLine("1: Add BlueRay to collection");
            Console.WriteLine("2: See collection");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please enter the title, direction, year of release and cost in that order");
                string t = Console.ReadLine();
                string d = Console.ReadLine();
                int y = int.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                collection.add(t, d, y, c);
            }
            if (choice == 2)
            {
                collection.show_all();
            }
        }
    }
}