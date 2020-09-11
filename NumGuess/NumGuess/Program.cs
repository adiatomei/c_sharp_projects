using System;


namespace NumGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the getAppInfo function
            getAppInfo();

            //Call the greetAndNAme function
            greetAndName();
            int guess = 0;
            string answer;
            int responses = 0;
            //Play the game
            while(true)
            {
                Random random = new Random();
                int theNum = random.Next(1, 10);
                Console.WriteLine("Write a name betweem 1 and 10");
                //Call the random number function
              
                while(guess != theNum)
                {
                    string input = Console.ReadLine();

                    if(!int.TryParse(input, out guess))
                    {
                        theColorMessage(ConsoleColor.Red, "Please insert and actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if(guess != theNum)
                    {
                        theColorMessage(ConsoleColor.Red, "Please try again");
                        responses++;
                        continue;
                    }
                }

                theColorMessage(ConsoleColor.Green, "You are correct.", responses);
                Console.WriteLine("Do You want to play again? [Y or N]");
                answer = Console.ReadLine().ToLower();
                if(answer == "y")
                {
                    continue;
                }
                else if(answer == "n")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
        // Get the info function
        static void getAppInfo()
        {
            string appName = "Number Guesser";
            string appVers = "1.0.0.2";
            string name = "Atomei Adi";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0} version {1} {2}", appName, appVers, name);
            Console.ResetColor();
        }

        //Get the name and greet function
        static void greetAndName()
        {
            Console.WriteLine("What it is your name, brave player?");
            string inpName = Console.ReadLine();
            Console.WriteLine("Let's play an extraodnary game, {0}", inpName);
        }

        
        //The background color message
        static void theColorMessage(ConsoleColor color, string message, int trys = -1)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if(trys >= 0)
            {
                Console.WriteLine(" You try {0}", trys);
            }
            
            Console.ResetColor();
        }

    }
}
