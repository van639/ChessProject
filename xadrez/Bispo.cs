using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
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

            //nordeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha--; posicao.Coluna++;
            }

            //sudeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha++; posicao.Coluna++;
            }

            //sudoeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha++; posicao.Coluna--;
            }

            //noroeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.PegarPeca(posicao) != null && Tabuleiro.PegarPeca(posicao).Cor != Cor)
                    break;
                posicao.Linha--; posicao.Coluna--;
            }


            return mat;
        }

        public override string ToString() => "B";
    
    }
}
