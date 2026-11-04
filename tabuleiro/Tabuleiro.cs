using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject.tabuleiro
{
    public class Tabuleiro
    {
        public int linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int colunas)
        {
            this.linha = linha;
            Colunas = colunas;
            Pecas = new Peca[linha, colunas];
        }
    }
}
