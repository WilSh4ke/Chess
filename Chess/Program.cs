using System;
using Chess.tabuleiro;
using Chess.xadrez;
using tabuleiro;
using xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);


                }


                Tela.imprimirTabuleiro(partida.tab);
           }
            catch (TabuleiroExeption e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();

        }
    }
}
