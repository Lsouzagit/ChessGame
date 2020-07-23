using System;
using System.Collections.Generic;
using System.Text;
using ChessGame;
using ChessGame.board;

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
        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }

        public bool existPiece(Position pos)
        {
            checkPosition(pos);
            return piece(pos) != null;
        }

        public void placepiece(Piece p, Position pos)
        {
            if (existPiece(pos))
            {
                throw new BoardException("Error: Already have a piece in this position");
            }
            pieces[pos.line, pos.column] = p;
            p.Position = pos;
        }

        public Piece removePiece(Position pos)
        {
            if(piece(pos) == null)
            {
                return null;
            }
            Piece aux = piece(pos);
            aux.Position = null;
            pieces[pos.line, pos.column] = null;
            return aux;
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.line, pos.column];
        }

        public bool validPosition(Position pos)
        {
            if(pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void checkPosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Error: The position is invalid");
            }
        }
    }
}
