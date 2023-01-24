using System;
namespace lab3
{
	public class question
	{
		private String questionText;
		private String answer;
		private int difficulty;

		public question(String text, String answer, int diff)
		{
			questionText = text;
			this.answer = answer;
			difficulty = diff;
		}
		public String getQuestion()
		{
			return questionText;
		}
		public String getAnswer()
		{
			return this.answer;
		}
		public int getDifficulty()
		{
			return difficulty;
		}

		public void changeQuestion()
		{
			questionText = Console.ReadLine();
		}
		public void changeAnswer()
		{
			answer = Console.ReadLine();
		}
		public void changeDifficulty()
		{
			int a = int.Parse(Console.ReadLine());
			if (a > 3)
			{
				Console.WriteLine("Thats too hard");
			} else
			{
				difficulty = a;
			}
		}
	}
}

