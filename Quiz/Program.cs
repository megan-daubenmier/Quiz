using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> multiChoiceChoices = new List<string> { "2021", "1904", "happy birthday", "2017" };
            List<string> checkBoxChoices = new List<string> { "Oxygen", "Helium", "Hydrogen", "Carbon" };
            List<string> checkBoxAnswers = new List<string> { "Helium", "Hydrogen" };
            
            Question trueFalse = new TrueFalse("The moon is in space.", 1, "true");
            Question multiChoice = new MultipleChoice("What year is it?", 1, "2021", multiChoiceChoices);
            Question checkbox = new Checkbox("Which two elements make up the sun?", 2, checkBoxChoices, checkBoxAnswers);
            List<Question> questions = new List<Question>{ trueFalse, multiChoice, checkbox};
            Quiz quiz = new Quiz(questions);
            quiz.GiveQuiz();
            quiz.GetGrade();
        }
    }
}
