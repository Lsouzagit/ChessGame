using ChessGame.board;
using System;
using ChessGame.chess;

namespace ChessGame
{
    class Tela
    {
        public static void printscreen(Board board)
        {
            for(int i = 0; i < board.lines; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < board.columns; j++)
                {   
                printPiece(board.piece(i, j));                                                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printscreen(Board board, bool[,] possiblemoves)
        {
            ConsoleColor originalcolor = Console.BackgroundColor;
            ConsoleColor newcolor = ConsoleColor.DarkGray;
            for (int i = 0; i < board.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++)
                {
                    if (possiblemoves[i, j])
                    {
                        Console.BackgroundColor = newcolor;
                    }
                    else
                    {
                        Console.BackgroundColor = originalcolor;                        
                    }
                    printPiece(board.piece(i, j));
                    Console.BackgroundColor = originalcolor;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = originalcolor;
        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }

        public static void printPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.Color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
