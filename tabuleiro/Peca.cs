using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace ChessProject.tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public CorEnum Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao,
                    Tabuleiro tabuleiro,
                    CorEnum cor)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
