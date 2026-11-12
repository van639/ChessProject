using ChessProject.tabuleiro;
using ChessProject.xadrez;
using tabuleiro;
using xadrez;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();
                while (!partidaDeXadrez.Terminada) 
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.tabuleiro);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();

                    bool[,] posicoesPossiveis = partidaDeXadrez.tabuleiro.PegarPeca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();

                    partidaDeXadrez.ExecutarMovimento(origem, destino);
                }
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
