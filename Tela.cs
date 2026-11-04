using ChessProject.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    string imprimirPeca = tabuleiro.PegarPeca(i,j) == null ? "-" : tabuleiro.PegarPeca(i,j).ToString();
                    Console.Write($"{imprimirPeca} ");
                }
                Console.WriteLine();
            }
        }
    }
}
