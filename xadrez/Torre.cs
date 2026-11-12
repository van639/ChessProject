using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
        {
        }

        public bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.PegarPeca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linha, Tabuleiro.Coluna];
            Posicao posicao = new Posicao(0, 0);

            //norte
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha--;
            }

            //leste
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Coluna++;
            }

            //sul
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if(Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha++;
            }

            //oeste
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if(Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Coluna--;
            }

            return mat;
        }
        public override string ToString() => "T";
    
    }
}
