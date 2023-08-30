using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP60_A2_Lalonde
{
    /// COMP 60 Asst 2
    /// author: Philip Lalonde
    /// purpose: Class to define a player.
    class Player
    {
        public string name;
        public int score,
                   wins,
                   losses;

        public Player(string iName)
        {
            score = 0;
            wins = 0;
            losses = 0;
            name = iName;
        }
    }
}
