using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
        {
        }
        public bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.PegarPeca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao posicao = new Posicao(0, 0);

            return mat;
        }

        public override string ToString() => "P";
        
    }
}
