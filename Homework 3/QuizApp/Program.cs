using System;
using System.Collections.Generic;
using System.IO;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Hello World!");
            
            List <user> users = UserService.populateUsers();
            
            int counter = 0;
            int score = 0;
            bool logedTeacher = false;
            bool IsLoggedIn = false;
            while (true)
            {
            List<user> usersTested = new List<user>();

            Console.WriteLine("Enter a Username");

            string userName = Console.ReadLine();

            user logedUSer = UserService.UserNameCheck(userName, users);

             while(logedUSer == null)
            {
                userName = Console.ReadLine();

                logedUSer = UserService.UserNameCheck(userName, users);
            }

            Console.WriteLine(logedUSer.Username);


            Console.WriteLine("Enter password");

            string userPassword = Console.ReadLine();

            UserService.PasswordCheck(userPassword, logedUSer, ref counter, usersTested,  ref IsLoggedIn, ref score, ref logedTeacher);

            while(IsLoggedIn == false && counter < 3)
            {
                Console.WriteLine("Enter password");

                userPassword = Console.ReadLine();

                UserService.PasswordCheck(userPassword, logedUSer, ref counter, usersTested, ref IsLoggedIn, ref score, ref logedTeacher);
            }

            if (counter >= 3)
            {
                Console.WriteLine($"You entered incorect password {counter} times, press any key to exit the application");

                var buttonPress = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(buttonPress))
                {
                    Environment.Exit(0);
                }
                

            }

                foreach (user user in usersTested)
                {

                    Console.WriteLine(user.Username);
                    Console.WriteLine($"Your score is {score}");
                    IsLoggedIn = false;
                    counter = 0;
                    score = 0;

                }
                TextWriter tw = new StreamWriter("TestedUser.txt");

                foreach (var user in usersTested)
                {
                    tw = File.AppendText(user.Username);
                    //tw.WriteLine(user.Username);
                    tw.Close();
                }

                



                if (IsLoggedIn)
             {
                 UserService.printStudent(users);
             }

                Console.WriteLine(counter);

            




            }
            //Prompt user to enter username -> string username = Readline()
            //check if the username exist (create a method in UserService that will query the List provided for the given username)
            //user userToCheck = CheckUsername method accepts username users (where user.Usename = username) returns user object (if else logic whether exists or not (null or not))
            //prompt user to enter password -> string password = Readline()
            //check whether password == user.Password 
            //(if true -> continue to check user Role, else counter++) {if user.Role == Role.Teacher or Role.Student}
            //if counter == 3 -> return (terminate) application

            //case when User is Student
            //Class Question (properties: string question, int correct answer)
            //start for loop that goes to the lengts of the question list
            //Writeline 1st Question -> instantiate object of Class Question for wvery question of the Data and create a list with the questions
            //Readline 1st answer -> validate whether answer is integer and if it is 1 to 4. If not show appropriate message and terminate, if yes add 1 to score and show the score in the console

            //case when User is Teacher
            // Print in console with green color the users from usrsTested and with red color the list of users that are not equal tousrsTested
            //Enter pressed tlogs the teacher out 


            Console.ReadLine();
        }
    }
}
