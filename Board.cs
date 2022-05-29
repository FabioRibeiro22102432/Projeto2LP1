using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Board
    {
        public int[] board;

        public Board()
        {
        this.board = buildBoard(new Random());
        }

        public int[] getBoard()
        {
        return board;
        }

        public int[] buildBoard(Random rand)                // feito por Bruno e Fabio (para o relatorio)
        {
            int cobraPosition = rand.Next(10, 24);
            int amountBoost = rand.Next(0, 3);
            int amountUTurn = rand.Next(0, 3);
            int[] boostPosition = new int[amountBoost];
            int[] uTurnPosition = new int[amountUTurn];

            if (amountBoost != 0)
            {
                boostPosition = boostMaker(amountBoost, 1, 20, rand);
            }
            
            if (amountUTurn != 0)
            {
                uTurnPosition = boostMaker(amountUTurn, 5, 24, rand);
            }

            int[] board = new int[25];
            for (int i = 0; i < board.Length; i++)
            {
                if (cobraPosition == i)
                {
                    board[i] = 4;
                }
                else
                {
                    board[i] = 0;
                }

                if (amountBoost != 0)
                {
                    for (int j = 0; j < amountBoost; j++)
                    {
                        if (boostPosition[j] == i)
                        {
                            board[i] = 5;
                        }
                    }
                }
                if (amountUTurn != 0)
                {
                    for (int j = 0; j < amountUTurn; j++)
                    {
                        if (uTurnPosition[j] == i)
                        {
                            board[i] = 6;
                        }
                    }
                }
            }

            return board;

        }
    }
}