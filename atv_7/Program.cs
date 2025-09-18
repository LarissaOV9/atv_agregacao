using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Curso curso = new Curso();

            aluno.nomeAluno = "Ana";
            aluno.matriculaAluno = 45;

            curso.aluno = aluno;
            curso.nomeCurso = "Engenharia";
            curso.ExibirDados();
        }
        public class Aluno
        {
            public string nomeAluno;
            public int matriculaAluno;
        }
        public class Curso
        {
            public string nomeCurso;
            public Aluno aluno;

            public void ExibirDados()
            {
                Console.WriteLine($"O curso de {nomeCurso} possui uma estudante chamada {aluno.nomeAluno}, cujo número da matrícula é: {aluno.matriculaAluno}.");
            }
        }
    }
}
