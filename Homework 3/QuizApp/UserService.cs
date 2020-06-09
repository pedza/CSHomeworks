using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace QuizApp
{
    class UserService
    {
        
        

        public static List<user> populateUsers()
        {
            user alek = new user("alekk", "alekk", Role.Teacher);
            user deki = new user("dekib", "DejanB", Role.Teacher);
            user st1 = new user("pedza", "pedza", Role.Student);
            user st2 = new user("vesna", "vesna", Role.Student);
            user st3 = new user("ivica", "ivica", Role.Student);
            user st4 = new user("ivan", "ivan", Role.Student);

            List<user> users = new List<user>();
            users.Add(alek);
            users.Add(deki);
            users.Add(st1);
            users.Add(st2);
            users.Add(st3);
            users.Add(st4);
            return users; 
        }

        public static user UserNameCheck(string username, List<user> users)
        {
            foreach (user user in users)
            {
                if (user.Username == username)
                {

                    return user;

                }


            }



            Console.WriteLine("Invalid Username try again");


            return null;
        }

        public static void PasswordCheck(string password, user user, ref int counter, List <user> usersTested, ref bool logedIn, ref int score, ref bool logedTeacher)
         {
            if(user.Password == password)
            {
                if (user.Role == Role.Student)
                {

                     printQuestions(PopulateQuestionList(), ref score, usersTested, user);

                    logedIn = true;
                    
                   
                }
                else if(user.Role == Role.Teacher)
                {
                    logedTeacher = true;
                    logedIn = true;
                }
            }
            else
            {
                Console.WriteLine("Incorect Password");
                counter++;
            }
        }

        
        
        
        

       

        public static List<Questions> PopulateQuestionList()
        {
            List<string> question1Choice = new List<string>();
            question1Choice.Add("1.  Dodoma");
            question1Choice.Add("2.  Hobart");
            question1Choice.Add("3.  Launceston");
            question1Choice.Add("4.  Wellington");

            List<string> question2Choice = new List<string>();
            question2Choice.Add("1. Kinshasa Democratic Republic of the Congo Temple");
            question2Choice.Add("2.  Palais de la Nation");
            question2Choice.Add("3.  Kongo Trade Centre");
            question2Choice.Add("4.  Nabemba Tower");

            List<string> question3Choice = new List<string>();
            question3Choice.Add("1. Styx");
            question3Choice.Add("2.  Hydra");
            question3Choice.Add("3.  Nix");
            question3Choice.Add("4.  Lugia");

            List<string> question4Choice = new List<string>();
            question4Choice.Add("1. Onega Lake");
            question4Choice.Add("2.  Benxi Lake");
            question4Choice.Add("3.  Kivu Lake");
            question4Choice.Add("4.  Wakatipu Lake");

            List<string> question5Choice = new List<string>();
            question5Choice.Add("1. Chad");
            question5Choice.Add("2.  Peru");
            question5Choice.Add("3.  Australia");
            question5Choice.Add("4.  Niger");

            Questions question1 = new Questions("What is the capital of Tasmania?", 2, question1Choice);
            Questions question2 = new Questions("What is the tallest building in the Republic of the Congo?", 4, question2Choice);
            Questions question3 = new Questions("Which of these is not one of Pluto's moons?", 4, question3Choice);
            Questions question4 = new Questions("What is the smallest lake in the world?", 2, question4Choice);
            Questions question5 = new Questions("What country has the largest population of alpacas??", 2, question5Choice);

            List<Questions> QuestionList = new List<Questions>();
            QuestionList.Add(question1);
            QuestionList.Add(question2);
            QuestionList.Add(question3);
            QuestionList.Add(question4);
            QuestionList.Add(question5);
            return QuestionList;
        }

        public static void printQuestions(List <Questions> questions, ref int score, List<user> usersTested, user user)
        {
            
            usersTested.Add(user);

            foreach (Questions question in questions)
            {
                Console.WriteLine(question.Question);
                question.QuestionChoice.ForEach(el => Console.WriteLine(el));
                
                string givenAnswer =  Console.ReadLine();
                int answerInNum;
                bool parseAnswer = int.TryParse(givenAnswer, out answerInNum);
                if (answerInNum <= 4 && answerInNum != 0)
                {
                    if(question.CorrectAnswer == answerInNum)
                    {
                        score++;
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        Console.WriteLine("Incorect");
                    }
                }
                else
                {
                    while(answerInNum > 4 || answerInNum == 0)
                    {
                        Console.WriteLine("Answer is not valid please insert number between 1 and 4");

                        givenAnswer = Console.ReadLine();

                        parseAnswer = int.TryParse(givenAnswer, out answerInNum);

                        if (answerInNum <= 4 && answerInNum != 0)

                            if (question.CorrectAnswer == answerInNum)
                        {

                            Console.WriteLine("Correct");
                        }
                        else
                        {
                            Console.WriteLine("Incorect");
                        }


                    }

                }
                

            }
            
        }

        public static void printStudent(List<user>allUsers)
        {
            //var filteredSequence = allUsers.Where(x => testedUsers.Contains(x));
            TextReader tr = new StreamReader("TestedUser.txt");
            string textUserTested;
            while((textUserTested = tr.ReadLine()) != null)
            {

            
            foreach(var user in allUsers)
            {
                if(user.Role == Role.Student) 
                {
                
                foreach(var u in textUserTested)
                {
                    if(u.ToString() == user.Username)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine(u);
                    }
                    else
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(user.Username);

                    }
                }
            }
                }
            }
        }

    }
}
