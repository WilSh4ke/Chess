﻿using System;
using Chess.tabuleiro;
using xadrez;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 1));


            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();



        }
    }
}
