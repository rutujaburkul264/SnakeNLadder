using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeNLadder
{
    class Program
    {
        public static int Main(String[] args)
        {
            UC2_SnakeNLadder player = new UC2_SnakeNLadder();
            UC3_SnakeNLadder board = new UC3_SnakeNLadder();

            Console.WriteLine("\n*****************************************************************\n");
            Console.WriteLine("\t\t Snake and Ladder Board");
            Console.WriteLine("\n*****************************************************************\n");

            Console.WriteLine("********************Dice score************************");
            int score;
            int count = 0;
            while (true)
            {
                player.previousPosition = player.currentPosition;
                score = player.RollingDice();
                count++;
                player.currentPosition = board.nextposition(score, player.previousPosition);
                if (player.currentPosition > 100)
                    player.currentPosition = player.previousPosition;

                Console.WriteLine(" Player1 : " + player1.name + "\t|| No of time dice roll :" + count1);
                Console.WriteLine(" Previous Position :\t" + player1.previousPosition);
                Console.WriteLine(" \n Dice Score :\t" + score);
                Console.WriteLine(" \n Current Position :\t" + player1.currentPosition);
                Console.WriteLine("----------------------------------------------------");

                if (player.currentPosition == 100)
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

