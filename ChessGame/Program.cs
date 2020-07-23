using System;
using ChessGame.board;
using ChessGame.chess;
namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Chessplay game = new Chessplay();

                while (!game.gamefinish)
                {
                    Console.Clear();
                    Tela.printscreen(game.board);

                    Console.WriteLine();
                    Console.Write("From: ");
                    Position from = Tela.readChessPosition().toPosition();
                    Console.Write("To: ");
                    Position to = Tela.readChessPosition().toPosition();
                    game.executeMove(from, to);
                }
                
                
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
