using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MultipleChoice : Question
    {
        public MultipleChoice(string question, int numPoints, string answer, List<string> choices) : base(question, numPoints)
        {
            CorrectAnswer = answer;
            AnswerChoices = choices;
        }
        
    }
}
