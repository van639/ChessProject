using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
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

            //norte
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //nordeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //leste
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //suldeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //sul
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //suldoeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //oeste
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna -1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;

            //noroeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna -1);
            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
              mat[posicao.Linha, posicao.Coluna] = true;
            
            return mat;
        }

        public override string ToString() => "R";
    
    }
}
