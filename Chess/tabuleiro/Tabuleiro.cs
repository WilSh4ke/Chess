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
        private int v1;
        private int v2;

        public Tabuleiro(int linhas, int colunas, Peca[,] pecas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = pecas;
            pecas = new Peca[linhas, colunas];
        }

        public Tabuleiro(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
