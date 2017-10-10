using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Rochambeau
{
    abstract class Player
    {
        protected string name;
        protected RPSGenerator rpsList;

        public Player(RPSGenerator r)
        {
            rpsList = r;
        }

        public string GetName()
        {
            return name;
        }

        public abstract string GenerateRPS();
    }
}
