﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class BlankBoard
    {

        private string[,] newBoard = {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
        };

        public void NewBoard()
        {
            string [,] ticTacToe = newBoard;
        }
    }
}
