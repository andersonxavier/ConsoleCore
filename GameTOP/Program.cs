using GameTOP.Lib;
using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(new Jogador1("Ronadlo"), new Jogador2("Anderson"));
            jogo.IniciarJogo();
        }
    }
}
