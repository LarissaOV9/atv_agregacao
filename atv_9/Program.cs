using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor diretor = new Diretor();
            Filme filme = new Filme();

            diretor.nomeDiretor = "Greta Gerwig";
            diretor.nacionalidadeDiretor = "Estados Unidos";

            filme.diretor = diretor;
            filme.tituloFilme = "Barbie";
            filme.ExibirDados();

        }
        public class Diretor
        {
            public string nomeDiretor;
            public string nacionalidadeDiretor;
        }
        public class Filme
        {
            public string tituloFilme;
            public Diretor diretor;

            public void ExibirDados()
            {
                Console.WriteLine($"O filme {tituloFilme} foi dirigido por {diretor.nomeDiretor}, nascida em {diretor.nacionalidadeDiretor}.");
            }
        }
    }
}
