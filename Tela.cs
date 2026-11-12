using ChessProject.tabuleiro;
using ChessProject.xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace ChessProject
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            var letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    ImprimirPeca(tabuleiro.PegarPeca(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine($"  {string.Join(" ", letras)}");
        }
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            var letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    Console.BackgroundColor = posicoesPossiveis[i, j] ? fundoAlterado : fundoOriginal;
                    ImprimirPeca(tabuleiro.PegarPeca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"  {string.Join(" ", letras)}");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == CorEnum.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    var aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
