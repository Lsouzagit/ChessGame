using System;
using System.Collections.Generic;
using System.Text;
using ChessGame;

namespace ChessGame.board
{
    class Board
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;
        public Board(int lines, int colums)
        {
            this.lines = lines;
            this.columns = colums;
            pieces = new Piece[lines, colums];
        }
    }
}
