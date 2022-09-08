using System;
using System.Collections.Generic;

namespace InteritanceStudioQuiz
{
    public class Checkbox : Question
    {
        public List<int> UserAnswers;
        public bool isCorrect;

        public Checkbox(string question, List<int> answer, List<string> possibleAnswers) : base(question, answer, possibleAnswers)
        {
        }

        //Asks question, loops through options, collects the response, and converts the response into a list of ints.
        public override void AskQuestion()
        {
            Console.WriteLine($"{QuestionText} Please reply with the number for each correct answer without spaces.");

            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {PossibleAnswers[i]}");
            }

            string response = Console.ReadLine();

            foreach(char j in response)
            {
                UserAnswers.Add(int.Parse(j.ToString()));
            }
        }

        //Checks the user's response and sees if it is in the list of answers.
        public override void CheckResponse()
        {
            foreach(int k in UserAnswers)
            {
                if(Answer.Contains(k))
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
}
