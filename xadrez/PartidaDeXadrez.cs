using ChessProject.tabuleiro;
using ChessProject.xadrez;
using tabuleiro;

namespace xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public CorEnum JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = CorEnum.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(peca, destino);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        private void MudaJogador() => JogadorAtual = JogadorAtual == CorEnum.Branca ? CorEnum.Preta : CorEnum.Branca;

        public void ValidarPosicaoDeOrigem(Posicao posicao)
        {
            if (Tabuleiro.PegarPeca(posicao) == null)
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            if (JogadorAtual != Tabuleiro.PegarPeca(posicao).Cor)
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            if (!Tabuleiro.PegarPeca(posicao).ExisteMovimentosPossiveis())
                throw new TabuleiroException("Não existe movimentos possíveis para essa peça!");
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (Tabuleiro.PegarPeca(origem).PodeMoverPara(destino))
                throw new TabuleiroException("Posição de destino inválida!");
        }

        private void ColocarPecas()
        {
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('e', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Rainha(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('d', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('f', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('c', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Cavalo(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('g', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Cavalo(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('b', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('a', 1).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, CorEnum.Branca), new PosicaoXadrez('h', 1).ConverterPosicao());


            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('e', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Rainha(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('d', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('f', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('c', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Cavalo(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('g', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Cavalo(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('b', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('a', 8).ConverterPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, CorEnum.Preta), new PosicaoXadrez('h', 8).ConverterPosicao());
        }
    }
}
