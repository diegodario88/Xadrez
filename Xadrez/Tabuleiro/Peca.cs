namespace tabuleiro
{
    class Peca
    {
        public Posicao PecaPosicao { get; set; }
        public Cor PecaCor { get; protected set; }
        public int QntMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public Peca (Cor cor, Tabuleiro tab)
        {
            PecaPosicao = null;
            PecaCor = cor;
            Tab = tab;
            QntMovimentos = 0;
        }
               
    }
}
