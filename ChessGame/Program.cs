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
                    try
                    {
                        Console.Clear();
                        Tela.printscreen(game.board);
                        Console.WriteLine();
                        Console.WriteLine("Turn: " + game.turn);
                        Console.WriteLine("Waiting " + game.actualPlayer + " make the move");

                        //ask the user wich piece he/her want move
                        Console.WriteLine();
                        Console.Write("From: ");
                        Position from = Tela.readChessPosition().toPosition();
                        game.checkfromposition(from);

                        //print possible places that that piece can be moved
                        bool[,] possiblepositions = game.board.piece(from).possiblemoves();
                        Console.Clear();
                        Tela.printscreen(game.board, possiblepositions);
                        Console.WriteLine();

                        //as to where the piece should go
                        Console.Write("To: ");
                        Position to = Tela.readChessPosition().toPosition();
                        game.checktoposition(from, to);
                        game.domove(from, to);
                    }
                    catch(BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }               
                
            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
