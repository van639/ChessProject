using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Rainha : Peca
    {
        public Rainha(Tabuleiro tabuleiro, 
                      CorEnum cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => "D";
    }
}
