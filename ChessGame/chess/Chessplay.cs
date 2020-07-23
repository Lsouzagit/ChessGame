using System;
using ChessGame.board;

namespace ChessGame.chess
{
    class Chessplay
    {
        public Board board { get; set; }
        public int turn { get; private set; }
        public Color actualPlayer { get; private set; }
        public bool gamefinish { get; private set; }

        public Chessplay()
        {
            board = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            gamefinish = false;
            putpieces();
        }

        public void executeMove(Position movefrom, Position moveto)
        {
            Piece p = board.removePiece(movefrom);
            p.sumQndMoves();
            Piece deadpiece = board.removePiece(moveto);
            board.placepiece(p, moveto);
        }

        public void domove(Position from, Position to)
        {
            executeMove(from, to);
            turn++;
            changeplayer();
        }

        public void checkfromposition(Position pos)
        {
            if (board.piece(pos) == null)
            {
                throw new BoardException("Don't exist any piece in the choosen position");
            }
            if (actualPlayer != board.piece(pos).Color)
            {
                throw new BoardException("You choose the other's player piece, please choose your piece.");
            }
            if (!board.piece(pos).havepossiblemoves())
            {
                throw new BoardException("This piece don't have possible moves.");
            }
        }

        public void checktoposition(Position from, Position to)
        {
            if (!board.piece(from).canmoveto(to))
            {
                throw new BoardException("The position you want move in invalid.");
            }
        }

        private void changeplayer()
        {
            if(actualPlayer == Color.White)
            {
                actualPlayer = Color.Black;
            }
            else
            {
                actualPlayer = Color.White;
            }
        }
        public void putpieces()
        {
            board.placepiece(new Tower(board, Color.Black), new ChessPosition('c', 1).toPosition());
            board.placepiece(new King(board, Color.White), new ChessPosition('h', 5).toPosition());
        }
    }
}
