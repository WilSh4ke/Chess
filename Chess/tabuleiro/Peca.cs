using System;
using System.Collections.Generic;
using System.Text;
using Chess.tabuleiro;


namespace Chess.tabuleiro
{
    class Peca
    {
        public Posicao Posisao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; set; }
        public  Tabuleiro tab { get; protected set; }


        public Peca(Cor cor, int qteMovimentos, Tabuleiro tab)
        {
            Posisao = null;
            Cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            Cor = cor;
        }
    }
}
