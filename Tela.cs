using ChessProject.tabuleiro;
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
                    if(tabuleiro.PegarPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.PegarPeca(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"  {string.Join(" ", letras)}");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == CorEnum.Branca)
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
        }
    }
}
