namespace ChessProject.tabuleiro
{
    public class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int colunas)
        {
            this.Linha = linha;
            Coluna = colunas;
            Pecas = new Peca[linha, colunas];
        }

        public Peca PegarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca PegarPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if(ExistePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            Peca peca = PegarPeca(posicao);
            if (peca == null)
                return null;
            
            peca.Posicao = null;
            Pecas[posicao.Linha, posicao.Coluna] = null;
            return peca;
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return PegarPeca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linha || posicao.Coluna < 0 || posicao.Coluna >= Coluna)
               return false;
            
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
                throw new TabuleiroException("Posição inválida!");
        }
    }
}
