using ChessProject.tabuleiro;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(new Tabuleiro(8, 8));
        }
    }
}
