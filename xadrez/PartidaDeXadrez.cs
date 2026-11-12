using ChessProject.tabuleiro;
using ChessProject.xadrez;
using tabuleiro;

namespace xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int turno;
        private CorEnum jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = CorEnum.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.RetirarPeca(origem);
            peca.IncrementarQtdMovimentos();
            Peca pecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            tabuleiro.ColocarPeca(new Rei(tabuleiro, CorEnum.Branca), new PosicaoXadrez('e', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Rainha(tabuleiro, CorEnum.Branca), new PosicaoXadrez('d', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, CorEnum.Branca), new PosicaoXadrez('f', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, CorEnum.Branca), new PosicaoXadrez('c', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, CorEnum.Branca), new PosicaoXadrez('g', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, CorEnum.Branca), new PosicaoXadrez('b', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Branca), new PosicaoXadrez('a', 1).ConverterPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Branca), new PosicaoXadrez('h', 1).ConverterPosicao());


            tabuleiro.ColocarPeca(new Rei(tabuleiro, CorEnum.Preta), new PosicaoXadrez('e', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Rainha(tabuleiro, CorEnum.Preta), new PosicaoXadrez('d', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, CorEnum.Preta), new PosicaoXadrez('f', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Bispo(tabuleiro, CorEnum.Preta), new PosicaoXadrez('c', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, CorEnum.Preta), new PosicaoXadrez('g', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, CorEnum.Preta), new PosicaoXadrez('b', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Preta), new PosicaoXadrez('a', 8).ConverterPosicao());
            tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Preta), new PosicaoXadrez('h', 8).ConverterPosicao());
        }
    }
}
