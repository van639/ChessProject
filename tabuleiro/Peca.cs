using tabuleiro;

namespace ChessProject.tabuleiro
{
    public class Peca
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

    }
}
