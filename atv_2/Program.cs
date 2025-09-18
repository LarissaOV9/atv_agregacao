using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Disciplina disciplina = new Disciplina();

            professor.nomeProfessor = "Geraldo";
            professor.especialidadeProfessor = "Matemáica e física";

            disciplina.professor = professor;
            disciplina.nomeDisciplina = "matemática";
            disciplina.ExibirDados();
        }
        public class Professor
        {
            public string nomeProfessor;
            public string especialidadeProfessor;
        }
        public class Disciplina
        {
            public string nomeDisciplina;
            public Professor professor;

            public void ExibirDados()
            {
                Console.WriteLine($"A disciplina {nomeDisciplina} é ensinada pelo professor {professor.nomeProfessor}, que é especialista em {professor.especialidadeProfessor}.");
            }
        }
    }
}
