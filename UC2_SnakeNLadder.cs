using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeNLadder
{
    class UC2_SnakeNLadder
    {
        public string name;
        public int currentPosition;
        public int previousPosition;

        public void player()
        {
            name = "";
            currentPosition = 0;
            previousPosition = 0;
        }
        public int RollingDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
