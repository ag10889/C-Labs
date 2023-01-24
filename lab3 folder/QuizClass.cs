using System;
using System.Collections;
namespace lab3
{
	public class QuizClass
	{
		List<question> questionBank = new List<question>();
		

        public void add_question(String questionText, String answer, int diff)
		{
            question a = new question(questionText, answer, diff);
            questionBank.Add(a);
		}
		public void remove_question()
		{
			int num = 1;
			for (int i = 0; i < questionBank.Count; i++)
			{
				Console.WriteLine(num++ + " " + questionBank[i].getQuestion());
			}
			Console.WriteLine("Which question would you like to remove?");
			String remove = Console.ReadLine();
			for (int i=questionBank.Count-1; i >=0; i--)
			{
				if (questionBank[i].getQuestion().Equals(remove))
				{
					questionBank.RemoveAt(i);
				}
			}

		}
		public void modify_question()
		{
            int num = 1;
            for (int i =0; i < questionBank.Count; i++)
            {
                Console.WriteLine(num++ + " " + questionBank[i].getQuestion());
            }
            Console.WriteLine("Which question would you like to change?");
            String change = Console.ReadLine();
			Console.WriteLine("Enter the new question");
			String changeQuestion = Console.ReadLine();
			Console.WriteLine("Enter the new answer");
			String changeAnswer = Console.ReadLine();
			Console.WriteLine("Enter the new difficulty");
			int changeDiff = int.Parse(Console.ReadLine());
            for (int i = questionBank.Count - 1; i >= 0; i--)
            {
                if (questionBank[i].getQuestion().Equals(change))
                {
					questionBank.Insert(i, new question(changeQuestion, changeAnswer, changeDiff));
                }
            }
        }
		public void give_quiz()
		{
			int correct = 0;
			int score = questionBank.Count;
			String answer;
			for (int i = 0;i < questionBank.Count; i++)
			{
				Console.WriteLine(questionBank[i].getQuestion());
				answer = Console.ReadLine();
				score++;
				if (answer.Equals(questionBank[i].getAnswer()))
				{
					correct++;
					Console.WriteLine("You got it right!");
				} else
				{
					Console.WriteLine("You got it wrong :(");
				}
            }
			Console.WriteLine("You got " + correct + " right");
		}
		
	}
}

