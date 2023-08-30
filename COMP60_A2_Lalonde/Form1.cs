using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace COMP60_A2_Lalonde
{
    /// COMP 60 Asst 2
    /// author: Philip Lalonde
    /// purpose: Colection of events & functions creates new game/player objects.
    ///          Allows game to be played unsing input fom player.
    public partial class LetterOfDoom : Form
    {
        public LetterOfDoom()
        {
            InitializeComponent();
        }

        static private Image[] prizePng = { Properties.Resources._1,Properties.Resources._2,
                                            Properties.Resources._3,Properties.Resources._4,
                                            Properties.Resources._5,Properties.Resources._6,
                                            Properties.Resources._7,Properties.Resources._8};
        private Label[] guessIndex;
        Game NewGame;
        Player Player1;
        private int scoreIndex = 0;
        private string guessLetter, guessList;
        private bool gameIsReady = true,
                     formIsOpen = false,
                     startSpinOpen = false;

        /// <summary>
        /// redacts word to be guessed
        /// </summary>
        /// <param name="wordLength"></param>
        /// <returns></returns>
        private string GenerateHidden(int wordLength)
        {
            return new string('-', wordLength);
        }

        /// <summary>
        /// Event starts a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGame_Click(object sender, EventArgs e)
        {
            if (gameIsReady && p1TxtBox.Text.Length >0)
            {
                Player1 = new Player(p1Name.Text);
                p1TxtBox.ReadOnly = true;
                guessIndex = new Label[] {labelA,labelB, labelC, labelD, labelE, labelF,
                                          labelG, labelH, labelI, labelJ, labelK,labelL,
                                          labelM, labelN, labelO, labelP, labelQ, labelR,
                                          labelS, labelT, labelU, labelV, labelW, labelX,
                                          labelY, labelZ};
                NewGameSetup();
                startSpinOpen = true;
            }
        }

        /// <summary>
        /// Event calls function to generate score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartScoreSpin(object sender, MouseEventArgs e)
        {
            if (startSpinOpen)
            {
                PrizeImageSpin();
                formIsOpen = true;
                gameIsReady = false;
                startSpinOpen = false;
            }
        }

        /// <summary>
        /// Event resets form with new word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWord_Click(object sender, EventArgs e)
        {
            if (TargetWordTxtbox.Text == NewGame.currentWord)
            {
                Player1.score = 0;
                Player1.wins += 1;
                GuessLetterTxtBox.Clear();
                LabelColorChangeBack();
                NewGameSetup();
                PrizeImageSpin();
                formIsOpen = true;
            }
        }

        /// <summary>
        /// Called when form is (re)set
        /// </summary>
        private void NewGameSetup()
        {
            NewGame = new Game();
            TargetWordTxtbox.Text = GenerateHidden(NewGame.currentWord.Length);
            ScoreTxtBox.Text = "" + Player1.score;
            guessList = "";   
        }

        /// <summary>
        /// Event clears text from guess text box and a helper label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuessDown(object sender, KeyEventArgs e)
        {
            GuessLetterTxtBox.Clear();
            guessHelper.Text = "";
        }

        /// <summary>
        /// Event uses typed letter to fill in redacted word, or take action if guess is wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuessUp(object sender, KeyEventArgs e)
        {
            if (formIsOpen)
            {
                guessLetter = GuessLetterTxtBox.Text.ToUpper();
                if (!guessList.Contains(guessLetter))
                {
                    char[] redactedProgress = TargetWordTxtbox.Text.ToUpper().ToCharArray();
                    LabelColorChange();
                    for (int ctr = 0; ctr < NewGame.currentWord.Length; ctr++)
                    {
                        if (guessLetter[0] == NewGame.currentWord[ctr])
                        {
                            redactedProgress[ctr] = guessLetter[0];
                            Player1.score += Game.prizeAmt[scoreIndex];
                        }
                    }
                    TargetWordTxtbox.Text = new string(redactedProgress);
                    ScoreTxtBox.Text = "" + Player1.score;
                    guessList = string.Concat(guessList, guessLetter);
                    if (TargetWordTxtbox.Text == NewGame.currentWord)
                    {
                        MessageBox.Show("You Won in " + guessList.Length + " guesses!\nFinal score: " + Player1.score);
                        formIsOpen = false;
                    }
                    else
                        PrizeImageSpin();
                }
                else
                    guessHelper.Text = "Duplicate guess";
            }
        }

        /// <summary>
        /// Cycles through array of images at varying 'speed'
        /// </summary>
        private void PrizeImageSpin()
        {
            /*int sleepCtr = 50;
            Random rand = new Random();

            for (int outCtr = 0; outCtr < 3; outCtr++)
            {
                scoreIndex = rand.Next(0, 9);

                for (int inCtr = 0; inCtr < prizePng.Length; inCtr++)
                {
                    PrizeImage.Image = prizePng[inCtr];
                    PrizeImage.Refresh();
                    Thread.Sleep(sleepCtr);
                    if (outCtr == 2 && inCtr == scoreIndex)
                        break;
                }
                sleepCtr += 30;
            }*/

            int sleepCtr = 50;
            Random rand = new Random();
            scoreIndex = rand.Next(0, 9);
            int maxSpin = scoreIndex + 20;
            int inCtr = 0;

            for (int outCtr = 0; outCtr < maxSpin; outCtr++)
            {
                PrizeImage.Image = prizePng[inCtr];
                PrizeImage.Refresh();
                Thread.Sleep(sleepCtr);
                if (outCtr > 20 && inCtr == scoreIndex)
                    break;
                if (inCtr == prizePng.Length-1)
                    inCtr = 0;
                else
                    inCtr++;
                sleepCtr += 5;
            }
        }

        /// <summary>
        /// Indicates guessed letters by changing a corresponding lable 
        /// </summary>
        private void LabelColorChange()
        {
            for (int index = 0; index < guessIndex.Length; index++)
            {
                if (guessIndex[index].Text == guessLetter)
                    guessIndex[index].ForeColor = Color.Tomato;
            }
        }

        /// <summary>
        /// removes label changes from guessed letters 
        /// </summary>
        private void LabelColorChangeBack()
        {
            char[] changeBack = guessList.ToCharArray();
            for (int ctr = 0; ctr < changeBack.Length; ctr++)
            {
                for (int index = 0; index < guessIndex.Length; index++)
                {
                    if (guessIndex[index].Text == changeBack[ctr].ToString())
                        guessIndex[index].ForeColor = Color.Black;
                }
            }
        }

    }
}

