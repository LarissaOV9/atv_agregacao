using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_agregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor();
            Livro livro = new Livro();

            autor.nomeAutor = "Mary Shelley";
            autor.nacionalidadeAutor = "Reino Unido";

            livro.autor = autor;
            livro.tituloLivro = "Frankeinstein";
            livro.ExibirDados();

        }
        public class Autor
        {
            public string nomeAutor;
            public string nacionalidadeAutor;
        }
        public class Livro
        {
            public string tituloLivro;
            public Autor autor;

            public void ExibirDados()
            {
                Console.WriteLine($"O livro {tituloLivro} foi escrito por {autor.nomeAutor} que nasceu em {autor.nacionalidadeAutor}.");
            }
        }
    }
}
