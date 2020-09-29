using System;
using System.Threading;
using System.Linq;
namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before we begin lets lay a few ground rules.");
            Thread.Sleep(2000);
            Console.WriteLine("Well currently there is none");
            Thread.Sleep(2000);
            Console.WriteLine("Well anyway are you ready to start? (yes/no)");
            string response = Console.ReadLine();

            if(response.ToLower() == "no")
            {
                Console.WriteLine("Well why did you start then...");
                Thread.Sleep(2000);
                Console.WriteLine("Fine... Good day!");
                Environment.Exit(0);
            }

            Console.WriteLine("Lets start...");
            Thread.Sleep(2000);
            Console.Clear();

            var spinner = new Spinner();
            spinner.Delay = 300;
            var num = 0;

            while(num <= 10)
            {
                num++;
             spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
            }
            Console.Clear();
           
            Console.WriteLine("lets begin the registration proccess");
            Thread.Sleep(2000);

            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            var userData = new User();
            userData.Username = name;

            Console.WriteLine("Hello {0}! To the bureau You will be known as agent #5", name);
            spinner.Delay = 300;
            num = 0;
            while (num <= 10)
            {
                num++;
                spinner.Turn(displayMsg: "Storing Data ", sequenceCode: 5);
            }
            Console.WriteLine("Data stored! This concludes our registration proccess.");
            Console.Clear();

            Console.WriteLine("Lets give you a bit of background info...");
            Thread.Sleep(1000);
            Console.WriteLine("You work for a special part of the government called 'The Cadence Protection Bureau'.");
            Console.WriteLine("Each agent has 1 life. Time has a funny way of retaliating when people like us mess with it. But if all goes smoothly then you should never lose your life.");
            Thread.Sleep(5000);
            Console.WriteLine("Anyway lets get to your first mission...");
            Thread.Sleep(2000);
            MissionOne();





        }
        static void MissionOne()
        {
            int[] rightGuess = { 1, 3, 9 };
            int determiner = 0;
            Console.WriteLine("Mission Details: Your mission is to find all time fragments that are hidden behind 10 doors. You won't know which door has them you just have to guess. You have 5 tries to get the right doors. CAUTION: if you run out of tries you lose a life.");
            Thread.Sleep(5000);
            Console.WriteLine("What is your first guess?");
            Console.Write("guess 1: ");
            var guess = Console.ReadLine();
            var number = int.Parse(guess);
            Console.WriteLine("You open the door and..");
            Thread.Sleep(1000);
            if (rightGuess.Contains(number))
            {
                determiner++;
                Console.WriteLine("you got one!");
            } else
            {
                Console.WriteLine("Thats not it..");
            }
            Console.WriteLine("What is your second guess?");
            Console.Write("guess 2: ");
            guess = Console.ReadLine();
            number = int.Parse(guess);
            Console.WriteLine("You open the door and..");
            Thread.Sleep(1000);
            if (rightGuess.Contains(number))
            {
                determiner++;
                Console.WriteLine("you got one!");
            }
            else
            {
                Console.WriteLine("Thats not it..");
            }
            Console.WriteLine("What is your third guess?");
            Console.Write("guess 3: ");
            guess = Console.ReadLine();
            number = int.Parse(guess);
            Console.WriteLine("You open the door and..");
            Thread.Sleep(1000);
            if (rightGuess.Contains(number))
            {
                determiner++;
                Console.WriteLine("you got one!");
            }
            else
            {
                Console.WriteLine("Thats not it..");
            }
            if(determiner == 3)
            {
                Console.WriteLine("You got them all!");

            } else
            {
            Console.WriteLine("What is your fourth guess?");
            Console.Write("guess 4: ");
            guess = Console.ReadLine();
            number = int.Parse(guess);
            Console.WriteLine("You open the door and..");
            Thread.Sleep(1000);
            if (rightGuess.Contains(number))
            {
                determiner++;
                Console.WriteLine("you got one!");
            }
            else
            {
                Console.WriteLine("Thats not it..");
            }
                if (determiner == 3)
                {
                    Console.WriteLine("You got them all!");

                } else
                {
                Console.WriteLine("What is your fifth guess?");
                Console.Write("guess 5: ");
                guess = Console.ReadLine();
                number = int.Parse(guess);
                Console.WriteLine("You open the door and..");
                Thread.Sleep(1000);
                if (rightGuess.Contains(number))
                {
                determiner++;
                Console.WriteLine("you got one!");
                }
                else
                {
                Console.WriteLine("Thats not it..");
                }
                if(determiner == 3)
                    {
                        Console.WriteLine("You got them all!");
                        Console.WriteLine("For now you win.");
                        Console.WriteLine("This concludes part 1 of this text adventure.");
                    } else
                    {
                        Console.WriteLine("You died because you failed the mission.");
                        Console.WriteLine("You lose the game please restart to try again.");
                    }
                }

                
            }
           
        }
    }
}
