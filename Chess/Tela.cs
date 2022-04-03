using System;
using System.Collections.Generic;
using System.Text;
using Chess.tabuleiro;

namespace Chess
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i<tab.linhas; i++){
                Console.Write(8 - i + " ");
                for(int j=0; j<tab.colunas; j++) { 
                
                    if(tab.peca(i, j) == null){
                Console.Write("- ");
            }
            else
            {
                Console.Write(tab.peca(i, j) + " ");
            }
                    
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            
        }
       public static void imprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
