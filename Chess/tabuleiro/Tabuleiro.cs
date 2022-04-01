using System;
using System.Collections.Generic;
using System.Text;
using Chess.tabuleiro;


namespace Chess.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas, Peca[,] pecas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = pecas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        } 

    }
}
