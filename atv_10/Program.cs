using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cantor cantor = new Cantor();
            Musica musica = new Musica();

            cantor.nomeCantor = "Michael Jackson";
            cantor.estiloCantor = "Pop";

            musica.cantor = cantor;
            musica.tituloMusica = "Thriller";
            musica.ExibirDados();
        }
        public class Cantor
        {
            public string nomeCantor;
            public string estiloCantor;
        }
        public class Musica
        {
            public string tituloMusica;
            public Cantor cantor;

            public void ExibirDados()
            {
                Console.WriteLine($"A música {tituloMusica} foi lançada por {cantor.nomeCantor}, cujo estilo musical é {cantor.estiloCantor}.");
            }
        }
    }
}
