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
        private int selectedCol; //Column piece is current at
        private int selectedRow; //Row piece is current at
        private int moveCol; //Column piece wants to move to
        private int moveRow; //Row piece wants to move to
        private int redPiecesLeft; //Number of red pieces left
        private int blackPiecesLeft;  //Number of black pieces left

        //Constructor
        public BoardModel()
        {
            selectedCol = 0;
            selectedRow = 0;
            moveCol = 0;
            moveRow = 0;
            redPiecesLeft = 12;
            blackPiecesLeft = 12;
        }


    }
}
