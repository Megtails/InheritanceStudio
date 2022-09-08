using System;
using System.Collections.Generic;

namespace InteritanceStudioQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkbox friends = new Checkbox("Which were characters in Friends?", new List<int> { 1, 3, 4}, new List<string> { "Phoebe", "Tom", "Ross", "Gunther" });


            friends.AskQuestion();
            friends.CheckResponse();

        }
    }
}