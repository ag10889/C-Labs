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
			foreach (var question in questionBank)
			{
				Console.WriteLine(question);
			}
			Console.WriteLine("Which question would you like to remove?");
			String remove = Console.ReadLine();

		}
		
	}
}

