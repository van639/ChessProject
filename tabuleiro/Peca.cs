using tabuleiro;

namespace ChessProject.tabuleiro
{
    public abstract class Peca
    {
        public Posicao? Posicao { get; set; }
        public CorEnum Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro,
                    CorEnum cor)
        {
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQtdMovimentos() => QtdMovimentos++;
        
        public bool ExisteMovimentosPossiveis()
        {
            var mat = MovimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Colunas; i++)
            {
                for (int x = 0; x < Tabuleiro.Linhas; x++)
                {
                    if (mat[x, i])
                        return true;
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao posicao) => MovimentosPossiveis()[posicao.Linha, posicao.Coluna];

    }
}
