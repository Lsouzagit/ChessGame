using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.board
{
    class Piece
    {
        public Color Color { get; protected set; }
        public Position Position { get; set; }
        public int QntMoves { get; protected set; }
        public Board Board { get; set; }
        
        public Piece(Position position, Board board, Color color)
        {
            this.Position = position;
            this.Board = board;
            this.Color = color;
            this.QntMoves = 0;
        }
    }
}
