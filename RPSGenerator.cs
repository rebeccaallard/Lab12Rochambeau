using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Rochambeau
{
    class RPSGenerator
    {
        List<string> rps = new List<string>();

        public RPSGenerator()
        {
            rps.Add("rock");
            rps.Add("paper");
            rps.Add("scissors");
        }

        public string GetBySTring(string gameInput)
        {
            if (gameInput == "r")
            {
                return rps[0];
            }
            else if (gameInput == "p")
            {
                return rps[1];
            }
            else if (gameInput == "s")
            {
                return rps[2];
            }

            return "-1";
        }

        public string opponent(string oppInput)
        {
            if (oppInput == "b")
            {
                return "Bullwinkle";
            }
            else if
            (oppInput == "r")
            {
                return "Rocky";
            }
            else
            {
                return "I don't know who you're talking about";
            }
        }

        public string playGame(string gameInput)
            {
            if (gameInput == "r")
            {
                return "Rock";
            }
            else if
                (gameInput == "p")
                {
                    return "Paper";
                }
            else if
                (gameInput == "s")
                {
                return "Scissors";
                }
            {
                return "I don't know what you mean";
            }
            }


        public string GetByIndex(int i)
        {
            string output;
            try
            {
                output = rps[i];
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("That was not a valid index put into the rps list");
                output = "-1";
            }

            return output;
        }
    }
}
