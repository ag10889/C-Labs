using System;
using System.Threading;
using System.Collections;
using System.IO;
public class Student
{
    int[] quiz = new int[10];
    int[] homework = new int[10];
    public int midterm;
    public int final;
    public double quizAverage;
    public double hwAverage;
    public double average;
    public string name;
    public int ID;

    public Student(string s) /*s is the name of the student whose grades need to be input into the system
                              * We will use a streamreader to find the document
                              * grab the details and input them as we did for lab 10
                              */
    {
        try
        {
            string[] data = s.Split(','); //splits the string at the commas
            name = data[0].Trim(); //since the string has been split, and I know where the data is I can substring
            ID = int.Parse(data[1].Trim());
            for (int i = 0; i < 10; i++)
            {
                quiz[i] = int.Parse(data[i + 2].Trim()); // Parse the integer from the string and trim whitespace
            }
            for (int i = 0; i < 10; i++)
            {
                homework[i] = int.Parse(data[i + 12].Trim()); // Parse the integer from the string and trim whitespace
            }
            midterm = int.Parse(data[22].Trim());
            final = int.Parse(data[23].Trim());
        }
        catch (FormatException e)
        {
            Console.WriteLine(e + " Student format eror");
        }
        catch (IOException e)
        {
            Console.WriteLine(e + "Student file error");
        }
        catch (Exception e)
        {
            Console.WriteLine(e + "Student Error");
        }
    }
    public void calcQuizAverage()
    {
        int low = quiz[0];
        int quizzes = 9;
        int grades = 0;
        for (int i = 0; i < 10; i++)
        {
            if (quiz[i] < low)
            {
                low = quiz[i];
            } else
            {
                grades += quiz[i];
            }
        }
        quizAverage = grades / quizzes;
    }
    public void calcHwAverage()
    {
        int low = homework[0];
        int hw = 9;
        int grades = 0;
        for (int i = 0; i < 10; i++)
        {
            if (homework[i] < low)
            {
                low = homework[i];
            }
            else
            {
                grades += homework[i];
            }
        }
        hwAverage = grades / hw;
    }
    public void calcOverallAverage()
    {
        double quizAv = (0.4 * quizAverage);
        double hwAv = (0.1 * hwAverage);
        double mideterm = (0.2 * this.midterm);
        double final = (0.3 * this.final);
        average = quizAv + hwAv + mideterm + final;
    }
    public void getGrade()
    {
        Console.WriteLine("HW Avg: " + hwAverage + " Midterm: " + midterm + " Final: " + final + " Overall Average " + average);
    }
}
public class Gradebook
{
    public LinkedList<Student> students = new LinkedList<Student>();
    public Gradebook(string fileName)
    {
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string lineNo = sr.ReadLine();
                Student student = new Student(lineNo);
                students.AddLast(student);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e + "Gradebook format error");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e + "Gradebook file not found");
        }
        catch (IOException e)
        {
            Console.WriteLine(e + "Gradebook file error");
        }
        catch (Exception e)
        {
            Console.WriteLine(e + "Gradebook Error");
        }
    }
    public Student getStudent(string name)
    {
        foreach (Student s in students)
        {
            if (s.name == name)
            {
                return s;
            }
        }
        return null;
    }
    public void getStudentGrade(string name)
    {
        foreach (Student s in students)
        {
            if (s.name == name)
            {
                s.getGrade();
            }
        }
    }
    public LinkedList<string> getAllStudentNames()
    {
        LinkedList<string> names = new LinkedList<string>();
        foreach (Student s in students)
        {
            names.AddLast(s.name);
        }
        return names;
    }

}
public class StatisticGradeBook : Gradebook
{
    public StatisticGradeBook(string gradeFile) : base(gradeFile)
    {

    }
    public void run()
    {
        LinkedList<string> names = new LinkedList<string>();
        int count = 0;
        foreach (Student s in students)
        {
            names.AddLast(s.name);
            
        }

        int total = students.Count;
        foreach (Student s in students)
        {
            s.calcQuizAverage();
            s.calcHwAverage();
            s.calcOverallAverage();
            count++;
            if (count % 100 == 0)
            {
                Console.WriteLine($"Calculating grades {count} out of {total}");
            }
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        StatisticGradeBook sg = new StatisticGradeBook("Assignment7-Spreadsheet (1).xlsx");
        Thread t1 = new Thread(sg.run);
        t1.Start();
        Console.WriteLine("What students grade would you like to pull up?");
        string name = Console.ReadLine();
        sg.getStudentGrade(name);
    }
}
