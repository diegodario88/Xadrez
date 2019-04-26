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
        public Peca PegaPeca(Posicao pos) => MatrizPecas[pos.Linha, pos.Coluna];
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }
            MatrizPecas[pos.Linha, pos.Coluna] = p;
            p.PecaPosicao = pos;
        }
        public bool PosicaoValida(Posicao pos)
        {
            return pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas ? false : true;
        }
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return PegaPeca(pos) != null;
        }

    }
}
