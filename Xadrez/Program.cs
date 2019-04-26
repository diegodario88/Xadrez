using System;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Preto, tab), new Posicao(3, 6));
                Tela.ImprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
