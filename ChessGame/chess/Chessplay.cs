using System;
using ChessGame.board;

namespace ChessGame.chess
{
    class Chessplay
    {
        public Board board { get; set; }
        private int turn;
        private Color actualPlayer;
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

        public void putpieces()
        {
            board.placepiece(new Tower(board, Color.Black), new ChessPosition('c', 1).toPosition());
        }
    }
}
