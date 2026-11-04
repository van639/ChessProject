using ChessProject.tabuleiro;
using tabuleiro;

namespace ChessProject.xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, CorEnum cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString() => "T";
    {
    }
}
