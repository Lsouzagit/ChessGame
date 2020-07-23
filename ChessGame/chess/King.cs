using ChessGame.board;

namespace ChessGame.chess
{
    class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }

        private bool canmove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.Color != this.Color;
        }
        
        public override bool[,] possiblemoves()
        {
            bool[,] mat = new bool[board.lines,board.columns];
            Position pos = new Position(0, 0);

            //north
            pos.definevalue(Position.line - 1, Position.column);
            if(board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //ne
            pos.definevalue(Position.line - 1, Position.column + 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //right
            pos.definevalue(Position.line, Position.column + 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //se
            pos.definevalue(Position.line + 1, Position.column + 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //south
            pos.definevalue(Position.line + 1, Position.column);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //sw
            pos.definevalue(Position.line + 1, Position.column - 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //left
            pos.definevalue(Position.line, Position.column -1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            //nw
            pos.definevalue(Position.line - 1, Position.column - 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                mat[pos.line, pos.column] = true;
            }

            return mat;
        }
    }
}
