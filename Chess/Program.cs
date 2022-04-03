using System;
using Chess.tabuleiro;
using tabuleiro;
using xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoChess pos = new PosicaoChess('a', 1);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

        }
    }
}
