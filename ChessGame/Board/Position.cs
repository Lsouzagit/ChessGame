
namespace ChessGame.board
{
    class Position
    {
        //Creating the atributes, a piece have a line and a column
        public int line { get; set; }
        public int column { get; set; }

        //When we call this class we need a constructor.
        public Position(int Line, int Column)
        {
            this.line = Line;
            this.column = Column;
        }

        public void definevalue(int line, int column)
        {
            this.line = line;
            this.column = column;
        }

        //To print the position on screen
        public override string ToString()
        {
            return line + "," + column;
        }

    }
}
