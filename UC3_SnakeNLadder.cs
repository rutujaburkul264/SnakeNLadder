using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeNLadder
{
    class UC3_SnakeNLadder
    {
        public int nextposition(int a, int b)
        {
            switch ( a + b )
            {
                case 8:
                    Console.WriteLine("Woww!!You got ladder at position 8 and goes upto 31");
                    return 31;
                    break;
                case 15:
                    Console.WriteLine("Woww!!You got ladder at position 15 and goes upto 97");
                    return 97;
                    break;
                case 42:
                    Console.WriteLine("Woww!!You got ladder at position 42 and goes upto 81");
                    return 81;
                    break;
                case 66:
                    Console.WriteLine("Woww!!You got ladder at position 66 and goes upto 87");
                    return 87;
                    break;
                case 24:
                    Console.WriteLine("Woww!!You got snake at position 24 and goes upto 1");
                    return 1;
                    break;
                case 55:
                    Console.WriteLine("Woww!!You got snake at position 55 and goes upto 13");
                    return 13;
                    break;
                case 71:
                    Console.WriteLine("Woww!!You got snake at position 71 and goes upto 29");
                    return 29;
                    break;
                case 88:
                    Console.WriteLine("Woww!!You got snake at position 88 and goes upto 54");
                    return 54;
                    break;
                case 99:
                    Console.WriteLine("Woww!!You got snake at position 99 and goes upto 6");
                    return 6;
                    break;
                default:
                    return (a + b);
                    break;
            }
        }
    }
}


