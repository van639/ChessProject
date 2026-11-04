using ChessProject.tabuleiro;
using ChessProject.xadrez;
using tabuleiro;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);
                //Console.WriteLine(posicaoXadrez.ConverterPosicao());
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, CorEnum.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, CorEnum.Preta), new Posicao(0, 1));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, CorEnum.Branca), new Posicao(3, 1));
                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
