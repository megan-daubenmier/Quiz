using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Checkbox : Question
    {
        public List<string> CorrectAnswers { get; set; }

        public Checkbox(string question, int numPoints, List<string> choices, List<string> answers) : base(question, numPoints, choices)
        {
            List<string> lowerCaseAnswers = new List<string>();

            foreach (string answer in answers)
            {
                lowerCaseAnswers.Add(answer.ToLower());
            }
            CorrectAnswers = lowerCaseAnswers;
        }
        public override int CheckAnswer(string userAnswers)
        {
            int points = 0;
            foreach (string answer in CorrectAnswers)
            {   
                if (userAnswers.ToLower().Contains(answer))
                {
                    points += PointValue / CorrectAnswers.Count;
                }
                    
            }
            return points;
        }

        
    }
}
