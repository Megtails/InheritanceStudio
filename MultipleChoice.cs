using System;
using System.Collections.Generic;

namespace InteritanceStudioQuiz
{
    public class MultipleChoice : Question
    {
        public int UserAnswer;
        public bool isCorrect;

        public MultipleChoice(string question, List<int> answer, List<string> possibleAnswers) : base(question, answer, possibleAnswers)
        {
        }

        //Asks questions and loops through potential responses before collecting user's answer and converting it to an int.
        public override void AskQuestion()
        {
            Console.WriteLine($"{QuestionText}");

            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {PossibleAnswers[i]}");
            }

            UserAnswer = int.Parse(Console.ReadLine());

        }

        //Checks the user's answer agains the value of the correct response and adds points if correct and subtracts if incorrect.
        public override void CheckResponse()
        {
            if (Answer[0] == UserAnswer)
            {
                isCorrect = true;
                Points += 5;
            } else
            {
                isCorrect = false;
                Points -= 5;
            }

        }
    }
}

