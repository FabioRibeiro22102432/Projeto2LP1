using System;

namespace Projeto2
{
    class Program
    {
     
        
        // Roll dice (1 - 6)
        /// <summary>
        ///  Number generator (die) 1-6
        /// </summary>
        /// <returns>random number between 1-6</returns>
        

        //makes a player roll the die to make a move
        /// <summary>
        /// Save the generated number by method dice
        /// </summary>
        /// <param name="player">which player</param>
        /// <returns>Saved number by method die</returns>
        
        static void Main(string[] args)
        {

         GameController gameController = new GameController();
            gameController.play();
        }
    }
}