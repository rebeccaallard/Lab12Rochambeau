using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Rochambeau
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSGenerator rps = new RPSGenerator();
            Rocky r = new Rocky(rps);

            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();

            Console.Write("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to play against Rocky or Bullwinkle (R/B)?: ");
            string oppInput = Console.ReadLine();
            oppInput = rps.opponent(oppInput);

            Console.WriteLine(yourName.ToLower() + " is playing against " + oppInput);

            bool run = true;
            while (run == true)

            {
                Console.Write("Rock, paper, or scissors? (R/P/S):");
                string gameInput = Console.ReadLine();
                gameInput = rps.playGame(gameInput);

                Console.WriteLine("Your selection is " + gameInput.ToLower());

          
                //Console.WriteLine(r.GenerateRPS());

                run = Continue();
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
                //SquaresAndCubes();
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye...");
                goOn = false;
            }
            else
            {
                //So this is a neat trick call recursion, it involves calling a method inside a method
                //In a sense it's another way of doing a loop, but using methods 
                //it works in much the same way, it's divided into two parts: 
                //a step and an end condition. 
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
    }
}


