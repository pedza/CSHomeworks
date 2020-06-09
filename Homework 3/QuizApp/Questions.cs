using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{ 
    public class Questions
    {
        public Questions(string question, int correctAnswer, List<string>questionChoice)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            QuestionChoice = questionChoice;
        }

        public string Question { get; set; }
        public int CorrectAnswer { get; set; }
        public List<string> QuestionChoice { get; set; }

         
        
        
    }   
}

     

   