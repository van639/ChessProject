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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro);
                        Console.WriteLine();
                        Console.WriteLine($"Turno: {partidaDeXadrez.Turno}");
                        Console.WriteLine($"Aguardando jogada: {partidaDeXadrez.JogadorAtual}");

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ConverterPosicao();
                        partidaDeXadrez.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partidaDeXadrez.Tabuleiro.PegarPeca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ConverterPosicao();
                        partidaDeXadrez.ValidarPosicaoDeDestino(origem, destino);

                        partidaDeXadrez.RealizaJogada(origem, destino);

                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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
