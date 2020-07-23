using ChessGame.board;

namespace ChessGame.chess
{
    class Tower : Piece
    {
        public Tower(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool canmove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.Color != this.Color;
        }

        public override bool[,] possiblemoves()
        {
            bool[,] mat = new bool[board.lines, board.columns];
            Position pos = new Position(0, 0);

            //north
            pos.definevalue(Position.line - 1, Position.column);
            if (board.validPosition(pos) && canmove(pos))
            {
                while (board.validPosition(pos) && canmove(pos))
                {
                    mat[pos.line, pos.column] = true;
                    if(board.piece(pos) != null && board.piece(pos).Color != Color)
                    {
                        break;
                    }
                    pos.line = pos.line - 1;
                }
                
            }

            //right
            pos.definevalue(Position.line, Position.column + 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                while (board.validPosition(pos) && canmove(pos))
                {
                    mat[pos.line, pos.column] = true;
                    if (board.piece(pos) != null && board.piece(pos).Color != Color)
                    {
                        break;
                    }
                    pos.column = pos.column + 1;
                }
            }

            //south
            pos.definevalue(Position.line + 1, Position.column);
            if (board.validPosition(pos) && canmove(pos))
            {
                while (board.validPosition(pos) && canmove(pos))
                {
                    mat[pos.line, pos.column] = true;
                    if (board.piece(pos) != null && board.piece(pos).Color != Color)
                    {
                        break;
                    }
                    pos.line = pos.line + 1;
                }
            }
                        
            //left
            pos.definevalue(Position.line, Position.column - 1);
            if (board.validPosition(pos) && canmove(pos))
            {
                while (board.validPosition(pos) && canmove(pos))
                {
                    mat[pos.line, pos.column] = true;
                    if (board.piece(pos) != null && board.piece(pos).Color != Color)
                    {
                        break;
                    }
                    pos.column = pos.column - 1;
                }
            }
                        
            return mat;
        }
    }
}