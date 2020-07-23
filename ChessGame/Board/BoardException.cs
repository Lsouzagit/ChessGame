using System;

namespace ChessGame.board
{
    class BoardException : Exception
    {
        public BoardException(string msg) : base(msg)
        {

        }
    }
}
