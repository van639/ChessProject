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
        private HashSet<Peca> Pecas = new();
        private HashSet<Peca> PecasCapturadas = new();

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
            if (pecaCapturada != null)
            {
                PecasCapturadas.Add(pecaCapturada);
            }
                
            
        }

        public HashSet<Peca> PecasJaCapturadas(CorEnum cor)
        {
            HashSet<Peca> aux = new();
            foreach (var x in PecasCapturadas)
            {
                if (cor == x.Cor)
                    aux.Add(x);
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(CorEnum cor)
        {
            HashSet<Peca> aux = new();
            foreach (var x in Pecas)
            {
                if (cor == x.Cor)
                    aux.Add(x);
            }
            aux.ExceptWith(PecasJaCapturadas(cor));
            return aux;
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
            if (!Tabuleiro.PegarPeca(origem).PodeMoverPara(destino))
                throw new TabuleiroException("Posição de destino inválida!");
        }

        private void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tabuleiro.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ConverterPosicao());
            Pecas.Add(peca);
        }

        private void ColocarPecas()
        {
            ColocarNovaPeca('e', 1, new Rei(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('d', 1, new Rainha(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('f', 1, new Bispo(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('c', 1, new Bispo(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('g', 1, new Cavalo(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('b', 1, new Cavalo(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('a', 1, new Torre(Tabuleiro, CorEnum.Branca));
            ColocarNovaPeca('h', 1, new Torre(Tabuleiro, CorEnum.Branca));


            ColocarNovaPeca('e', 8, new Rei(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('d', 8, new Rainha(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('f', 8, new Bispo(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('c', 8, new Bispo(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('g', 8, new Cavalo(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('b', 8, new Cavalo(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('a', 8, new Torre(Tabuleiro, CorEnum.Preta));
            ColocarNovaPeca('h', 8, new Torre(Tabuleiro, CorEnum.Preta));
        }
    }
}
