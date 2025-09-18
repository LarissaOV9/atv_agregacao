using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador();
            Time time = new Time();

            jogador.nomeJogador = "Matheus Pereira";
            jogador.posicaoJogador = "Atacante";

            time.jogador = jogador;
            time.nomeTime = "Cruzeiro";
            time.ExibirDados();
        }
        public class Jogador
        {
            public string nomeJogador;
            public string posicaoJogador;
        }
        public class Time
        {
            public string nomeTime;
            public Jogador jogador;

            public void ExibirDados()
            {
                Console.WriteLine($"O time {nomeTime} possui um jogador chamado {jogador.nomeJogador} que joga na posição de {jogador.posicaoJogador}.");
            }
        }
    }
}
