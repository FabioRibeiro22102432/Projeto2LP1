using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Dice
    {
        public int dice(Random rand)                   /// feito por Fabio (para o relatorio)
        {
        int dice = rand.Next(1, 7);
        return dice;
        }
    }
}