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
        s.Split(','); //splits the string at the commas
        name = s.Substring(0, 1); //since the string has been split, and I know where the data is I can substring
        ID = int.Parse(s.Substring(1, 2));
        for (int i = 0; i < 11; i++)
        {
            quiz[i] = int.Parse(s.Substring(i + 2, i + 3));
        }
        for (int i = 0; i < 11; i++)
        {
            homework[i] = int.Parse(s.Substring(i + 12, i + 13));
        }
        midterm = int.Parse(s.Substring(22, 23));
        final = int.Parse(s.Substring(s.Length - 2, s.Length - 1));
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
    LinkedList<Student> students = new LinkedList<Student>();
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
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e + "Error");
        }
        catch (IOException e)
        {
            Console.WriteLine(e + "Error");
        }
        catch (Exception e)
        {
            Console.WriteLine(e + "Error");
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
    public StatisticGradeBook(string gradeFiles) : base(gradeFiles)
    {

    }
}
