using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TrueFalse : Question
    {
        public TrueFalse(string question, int numPoints, string answer) : base(question, numPoints)
        {
            CorrectAnswer = answer;
            AnswerChoices = new List<string> { "True", "False" };
        }
        
    }
}
