using System;
using System.Collections.Generic;

namespace InteritanceStudioQuiz
{
    public class TrueFalse : Question
    {
        public int UserAnswer;
        public bool isCorrect;

        public TrueFalse(string question, List<int> answer, List<string> possibleAnswers) : base(question, answer, possibleAnswers)
        {
        }

        //Asks the user the question and presents the possible responses (true or false) before collecting the user's resposne.
        public override void AskQuestion()
        {
            Console.WriteLine($"{QuestionText}");
            Console.WriteLine($"1. {PossibleAnswers[0]} \n2.{PossibleAnswers[1]}");

            UserAnswer = (int.Parse(Console.ReadLine()) - 1);
        }

        //Checks the value of the user's answer against the actual answer's value.
        public override void CheckResponse()
        {
            if (Answer[0] == UserAnswer)
            {
                isCorrect = true;
                Points += 5;
            }
            else
            {
                isCorrect = false;
                Points -= 5;
            }

        }


    }
}

