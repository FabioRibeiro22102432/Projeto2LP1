using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Dice
    {
        // Roll dice (1 - 6)
        /// <summary>
        ///  Number generator (die) 1-6
        /// </summary>
        /// <returns>random number between 1-6</returns>
         public int dice(Random rand)                   
        {
        int dice = rand.Next(1, 7);
        return dice;
        }
    }
}