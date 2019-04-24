namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] MatrizPecas;
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            MatrizPecas = new Peca[Linhas, Colunas];
        }
        public Peca PegaPeca(int linha, int coluna) => MatrizPecas[linha, coluna];
        public void ColocarPeca(Peca p, Posicao pos)
        {
            MatrizPecas[pos.Linha, pos.Coluna] = p;
            p.PecaPosicao = pos;
        }

    }
}
