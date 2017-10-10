using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Rochambeau
{
    class Rocky : Player

    // Rocky always plays the rock option

    {
        public Rocky(RPSGenerator r) : base(r)
        {
            name = "Rocky";
        }

        public override string GenerateRPS()
        {
            return rpsList.GetByIndex(0);
        }
    }
}
