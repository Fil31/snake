using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class score
    {
        static void InitScore()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(1, 0);
            Console.Write("Score: 0");
        }
    }
}
