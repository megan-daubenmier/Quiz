using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public string QuestionBody { get; set; }
        public List<string> AnswerChoices { get; set; }
        public string CorrectAnswer { get; set; }
        public int PointValue { get; set; }

        public Question(string question, int numPoints)
        {
            QuestionBody = question;
            PointValue = numPoints;
        }

        public Question(string question, int numPoints, List<string> choices)
        {
            QuestionBody = question;
            PointValue = numPoints;
            AnswerChoices = choices;
        }

        public override string ToString()
        {
            string questionString = QuestionBody;
            foreach (string choice in AnswerChoices)
            {
                questionString += "\n" + choice;
            }
            return questionString;
        }

        public virtual int CheckAnswer(string answer)
        {
            if (answer.ToLower() == CorrectAnswer.ToLower())
            {
                return PointValue;
            }
            else
            {
                return 0;
            }
        }
    }
}
