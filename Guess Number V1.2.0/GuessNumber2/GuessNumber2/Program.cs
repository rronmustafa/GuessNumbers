using System;

namespace GuessNumberS
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //run  getappinfo function to get info

            GreetUser(); //ask for user name and greet

            for (int i = 0; i < 3; i++)
            {
                //init correct number
                int correctNum = 7;
                Random random = new Random();
                if (i == 0)
                    correctNum = random.Next(1, 5);
                if (i == 1)
                    correctNum = random.Next(1, 10);
                if (i == 2)
                    correctNum = random.Next(1, 15);
                //init guess number
                int guess = 0;

                //ask user to guess a number

                if (i == 0)
                {
                    Console.WriteLine("Beginner LEVEL 1");
                    Console.WriteLine("Guess a number between 1 and 5... Easy peasy");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Intermediate LEVEL 2");
                    Console.WriteLine("Guess a number between 1 and 10... Let's see now");
                }
                else if (i == 2)
                {
                    Console.WriteLine("Hard LEVEL 3");
                    Console.WriteLine("Guess a number between 1 and 15.. You gotta be very lucky now");
                }
                    //while guess is not correct
                while (guess != correctNum)
                {
                    //get user input/number
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        //Define the color and the message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Input!!! Type a number...");
                        continue;
                    }
                    //convert to int (input[string] => guess[int]) 
                    guess = Convert.ToInt32(input);

                    //match guess to correct number
                    if (guess != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number!!! Please try again");
                    }
                }

                //calling method and passing paramters for guessing the correct number
                PrintColorMessage(ConsoleColor.DarkYellow, "You Are Correct!!!");

                for (int j = 0; j < 3; j++)
                {
                    if (i < 2)
                    {
                        Console.WriteLine("You want to play next Level? Type [Y] or [N]");
                        break;
                    }
                    else
                    {
                        break;
                    }
                    continue;
                }
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("See you next time losser :P");
                    break;

                }
                else
                {
                    break;
                }
            }
            PrintColorMessage(ConsoleColor.Yellow, "Congratulation you Win, you are a really lucky guy...");
            Console.ReadKey();
        }
        //get and display app info
        static void GetAppInfo()
        {
            //Set application variables
            var appName = "Guess Numbers";
            var appVersion = "1.2.0";
            var appAuthor = "Rron Mustafa";

            //Change color of the text
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} by:{2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }
        //ask user name and greet   
        static void GreetUser()
        {
            //ask user name 
            Console.WriteLine("What is your name ?");

            //get user name
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game... ", userName);
        }
        //Print the color of the text and display message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text Color
            Console.ForegroundColor = color;

            //message
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
