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
            UC2_SnakeNLadder player1 = new UC2_SnakeNLadder();
            UC2_SnakeNLadder player2 = new UC2_SnakeNLadder();
            UC3_SnakeNLadder board = new UC3_SnakeNLadder();

            Console.WriteLine("\n*****************************************************************\n");
            Console.WriteLine("\t\t Snake and Ladder Board");
            Console.WriteLine("\n*****************************************************************\n");

            Console.WriteLine("Enter player1 name");
            player1.name = Console.ReadLine();
            Console.WriteLine("Enter player2 name");
            player2.name = Console.ReadLine();

            Console.WriteLine("********************Dice score************************");
            int score;
            int count1 = 0,count2 = 0;
            while (true)//UC4-repeat till the player reaches winning position 100
            {
                player1.previousPosition = player1.currentPosition;
                score = player1.RollingDice();
                count1++;
                player1.currentPosition = board.nextposition(score, player1.previousPosition);
                if (player1.currentPosition > 100)
                    player1.currentPosition = player1.previousPosition;

                //UC6-report number of times the dice was playedto win the game & also every position after every die is role
                Console.WriteLine(" Player1 : " + player1.name + "\t|| No of time dice roll :" + count1);
                Console.WriteLine(" Previous Position :\t" + player1.previousPosition);
                Console.WriteLine(" \n Dice Score :\t" + score);
                Console.WriteLine(" \n Current Position :\t" + player1.currentPosition);
                Console.WriteLine("----------------------------------------------------");

                if (player1.currentPosition == 100) //Ensure the player gets winning position
                {
                    Console.WriteLine("Player1 won the Game");
                    break;
                }
            }

            player2.previousPosition = player2.currentPosition;
            score = player2.RollingDice();
            count2++;
            player2.currentPosition = board.nextposition(score, player2.previousPosition);
            if (player2.currentPosition > 100)
                player2.currentPosition = player2.previousPosition;

            Console.WriteLine(" Player1 : " + player2.name + "\t|| No of time dice roll :" + count2);
            Console.WriteLine(" Previous Position :\t" + player2.previousPosition);
            Console.WriteLine(" \n Dice Score :\t" + score);
            Console.WriteLine(" \n Current Position :\t" + player2.currentPosition);
            Console.WriteLine("----------------------------------------------------");

            if (player2.currentPosition == 100)
            {
                Console.WriteLine("Player2 won the Game");
            }
            Thread.Sleep(2000);
            return 1;
        }
    }
}
