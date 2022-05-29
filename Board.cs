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

        /// <summary>
        /// Generates positions on the board with special tiles
        /// </summary>
        /// <param name="rand">random number between (x,y)</param>
        /// <returns>board with respective positions</returns>
        public int[] buildBoard(Random rand)                
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
        /// <summary>
        /// Prints board on console in zigzag  and Players in respective positions
        /// </summary>
        public  void printBoard()
        {

            //val is 25 - 1
            int val = board.Length - 1;
            int invert;

            Console.WriteLine("\n-----------------------------------");
            //while cycle that checks if the array has ended       
            while (val > -1)
            {
                if (val % 2 == 0)
                {
                    //invert is -4 when the line starting number is pair                 
                    invert = -4;
                }
                else
                {
                    //otherwise stays at 0
                    invert = 0;
                }
                //for cycle that starts in the last Index and goes through the array 5 by 5 elements
                for (int i = val; i > val - 5; i--)
                {
                    //if it is a normal tile prints empty
                    if (board[i + invert] == 0)
                    {  
                        Console.Write($"| {"",3:d} |");               
                    }
                    //if it is a "Cobra" tile prints "C"
                    else if (board[i + invert] == 4)
                    {
                        Console.Write($"| {"C",2:d}  |");
                    }
                    else if (board[i + invert] == 5)
                    {
                        Console.Write($"| {"B",2:d}  |");
                    }
                    else if (board[i + invert] == 6)
                    {
                        Console.Write($"| {"U",2:d}  |");
                    }
                    //if it is a player tile prints player
                    else
                    {
                        Console.Write($"| {"P" + board[i + invert],2:d}  |");
                    }
                    //changes the value of invert according to the array position    
                    if (val % 2 == 0)
                    {
                        invert += 2;
                    }
                }
                Console.WriteLine("\n-----------------------------------");
                val -= 5;
            }
        }
        
        public int[] boostMaker(int amount, int min, int max, Random rand)
        {
            int[] array = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }  


    }
}