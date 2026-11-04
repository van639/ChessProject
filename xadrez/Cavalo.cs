using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString() => "C";
    }
}
