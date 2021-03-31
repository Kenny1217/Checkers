using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Classes
{
    class BoardModel
    {
        /* Used to keep track of the pieces on the board.
         * -1 = invalid space, 0 = empty space, 1 = red player,
         * 2 = black player, 3 = red king, 4 = black king
         */
        private int[,] boardArray ={
                { 1, -1, 1, -1, 1, -1, 1, -1},
                { -1, 1, -1, 1, -1, 1, -1, 1},
                { 1, -1, 1, -1, 1, -1, 1, -1},
                { -1, 0, -1, 0, -1, 0, -1, 0},
                { 0, -1, 0, -1, 0, -1, 0, -1},
                { -1, 2, -1, 2, -1, 2, -1, 2},
                { 2, -1, 2, -1, 2, -1, 2, -1},
                { -1, 2, -1, 2, -1, 2, -1, 2}};



    }
}
