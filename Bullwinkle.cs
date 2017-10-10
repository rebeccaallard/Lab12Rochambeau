using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Rochambeau
{
    class Bullwinkle : Player

    // Bullwinkle plays a random option but for the sake of testing what's
    // been coded so far, he's playing the scissors option
    {
        public Bullwinkle(RPSGenerator s) : base(s)
        {
            name = "Bullwinkle";
        }

        public override string GenerateRPS()
        {
            return rpsList.GetByIndex(0);
        }
    }
}
