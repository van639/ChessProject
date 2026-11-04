using ChessProject.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject.xadrez
{
    public class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        /***  Coluna - 'a' Da para fazer essa operação matematica porque o char internamente 
              armazena um valor numérico correspondente ao código Unicode do caractere.
              exemplo: 'a' = 97, 'b' = 98, e assim por diante.
         ***/
        public Posicao ConverterPosicao() => new Posicao(8 - Linha, Coluna - 'a');

        public override string ToString() => $"{Coluna}{Linha}";
        
    }
}
