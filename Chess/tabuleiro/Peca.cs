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

        public Peca(Posicao posisao, Cor cor, int qteMovimentos, Tabuleiro tab)
        {
            Posisao = posisao;
            Cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }
    }
}
