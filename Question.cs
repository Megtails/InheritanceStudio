using System;
using System.Collections.Generic;

namespace InteritanceStudioQuiz
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public static int Points;
        public List<int> Answer { get; set; }
        public List<string> PossibleAnswers { get; set; }

        public Question(string question, List<int> answer, List<string> possibleAnswers)
        {
            QuestionText = question;
            Answer = answer;
            PossibleAnswers = possibleAnswers;
        }

        public abstract void AskQuestion();

        public abstract void CheckResponse();


    }
}

