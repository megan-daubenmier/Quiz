using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Quiz
    {
        public List<Question> QuizQuestions { get; set; }
        public double PointsEarned { get; set; }
        public int MaxPoints { get; set; }

        public Quiz (List<Question> questions)
        {
            int points = 0;
            QuizQuestions = questions;
            foreach(Question question in questions)
            {
                points += question.PointValue;
            }
            MaxPoints = points;

        }

        public void GiveQuiz()
        {
            foreach(Question question in QuizQuestions)
            {
               
                Console.WriteLine(question.ToString());
                string answer = Console.ReadLine();
                PointsEarned += question.CheckAnswer(answer);
                
            }
        }

        public void GetGrade()
        {
            Console.WriteLine("Your grade is: " + PointsEarned / MaxPoints * 100 + "%");
        }
    }
}
