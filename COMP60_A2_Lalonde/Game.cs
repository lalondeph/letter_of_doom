using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP60_A2_Lalonde
{
    /// COMP 60 Asst 2
    /// author: Philip Lalonde
    /// purpose: Class defines a word guessing game.
    class Game
    {
        static string[] words = {"PIZZA", "BLUE", "HARVARD", "SOCCER",
                                 "RAVIOLI", "BLACKBOARD", "VOLKSWAGEN", 
                                 "MONEY", "TROMBONE", "SPECIAL", "NULL",
                                 "CARPET", "QUESTION", "DRIVEWAY", 
                                 "CONSTRUCTOR"};
        public static int[] prizeAmt = { 0, 300, 700, 900, 1000, 1100, 1200, 1500, 2000 };
        public string currentWord;
        public Random rand;

        /// <summary>
        /// Called by constructor, selects rand word from an array
        /// </summary>
        private void AssignCurrentWord ()
        {
            currentWord = words[rand.Next(0, words.Length)];
        }

        public Game()
        {
            rand = new Random();
            AssignCurrentWord();
        }
    }
}
