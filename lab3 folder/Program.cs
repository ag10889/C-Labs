using System.Threading;

namespace lab3;
class Program
{
    static void Main(string[] args)
    {
        QuizClass newQuiz = new QuizClass();

        int choice;
        do
        {
            Console.WriteLine("1. Add a question to the quiz");
            Console.WriteLine("2. Remove a question from the quiz");
            Console.WriteLine("3. Modify a question in the quiz");
            Console.WriteLine("4. Take the quiz");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());



            if (choice == 1)
            {
                Console.WriteLine("What is the question text?");
                String questionText = Console.ReadLine();
                Console.WriteLine("What is the question answer?");
                String questionAnswer = Console.ReadLine();
                Console.WriteLine("What is the question difficulty?");
                int questionDiff = int.Parse(Console.ReadLine());
                newQuiz.add_question(questionText, questionAnswer, questionDiff);
            }
            else if (choice == 2)
            {

                newQuiz.remove_question();
            }
            else if (choice == 3)
            {

                newQuiz.modify_question();
            }
            else if (choice == 4)
            {
                newQuiz.give_quiz();
            }
        }
        while (choice < 5);
  
    }
}
