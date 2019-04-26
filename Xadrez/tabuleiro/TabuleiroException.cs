using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        //Constructor
        public TabuleiroException(string msg) : base(msg) { }
    }
}
