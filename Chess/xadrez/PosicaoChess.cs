using Chess.tabuleiro;
using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosicaoChess
    {
        public char coluna { get; set; }
        public int linha {get; set; }

        public PosicaoChess(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
