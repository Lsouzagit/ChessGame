using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.board
{
    abstract class Piece
    {
        public Color Color { get; protected set; }
        public Position Position { get; set; }
        public int QntMoves { get; protected set; }
        public Board board { get; set; }
        
        public Piece(Board board, Color color)
        {
            this.Position = null;
            this.board = board;
            this.Color = color;
            this.QntMoves = 0;
        }

        public void sumQndMoves()
        {
            QntMoves++;
        }

        public bool havepossiblemoves()
        {
            bool[,] mat = possiblemoves();
            for(int i = 0; i < board.lines; i++)
            {
                for(int j = 0; j < board.columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
        public bool canmoveto(Position pos)
        {
            return possiblemoves()[pos.line, pos.column]; //testa se é possível isso? na posição hein
        }

        public abstract bool[,] possiblemoves();        
    }
}
