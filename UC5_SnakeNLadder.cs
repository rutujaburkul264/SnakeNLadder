using System;
using System.Collections.Generic;
using System.Threading;


namespace SnakeNLadder
{
    class Program
    {
        public static int Main(String[] args)
        {
            // UC1 for single player
            UC2_SnakeNLadder player = new UC2_SnakeNLadder();
            UC3_SnakeNLadder board = new UC3_SnakeNLadder();

            Console.WriteLine("\n*****************************************************************\n");
            Console.WriteLine("\t\t Snake and Ladder Board");
            Console.WriteLine("\n*****************************************************************\n");

	    Console.WriteLine("********************Dice score************************");
            int score;
            int count = 0;
            while (true)//UC4-repeat till the player reaches winning position 100
            {
                player.previousPosition = player.currentPosition;
                score = player.RollingDice();
                count++;
                player.currentPosition = board.nextposition(score, player.previousPosition);
                if (player.currentPosition > 100)
                    player.currentPosition = player.previousPosition;
		
		if (player1.currentPosition == 100)
                {
                    Console.WriteLine("Player1 won the Game");
                    break;
                }
            }
	 Thread.Sleep(2000);
            return 1;
        }
    }
}

