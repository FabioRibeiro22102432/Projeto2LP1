using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{   
    public class GameController
    {
        private Dice dice;
        private Board board;
    /// <summary>
    /// Dice and Board from another class's
    /// </summary>
    public GameController()
    {
        this.dice = new Dice();
        this.board = new Board();
    }
    /// <summary>
    /// Ask's the user to press R/r to play
    /// and move player with the die number
    /// </summary>
    /// <param name="player"></param>
    /// <param name="rand"></param>
    /// <returns>die number</returns>
    private  int playerRoll(int player, Random rand)   
    {
        string input;
        bool played = false;
        int roll = this.dice.dice(rand);


        do
        {
            //Asks the player to roll the die
            Console.WriteLine($"Player{player}, it's your turn! Press /R to roll the die: ");
            //Reads the input of the player        
            input = Console.ReadLine();

            //if the input is correct (R or r) rolls the die
            if (input == "r" || input == "R")
            {
                //prints the number rolled
                Console.WriteLine($"\nPlayer{player} roll: {roll}; ");
                break;

            }
            //if the input is incorrect asks to press R again with a Error Message
            else
            {
                Console.WriteLine("Invalid input!!");
                Console.WriteLine("Please use /R to roll the die ");
            }
            //changes boolean to true so it can stop the cycle
            played = true;
        } while (played == true);

        //returns the number rolled in the die
        return roll;

    }
    