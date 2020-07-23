using System;
using ChessGame.board;
using ChessGame.chess;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board boa = new Board(8, 8);
            boa.placepiece(new Tower(boa, Color.Black), new Position(3, 5));
            Tela.printscreen(boa);
        }
    }
}
