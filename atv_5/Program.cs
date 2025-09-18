using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medico medico = new Medico();
            Paciente paciente = new Paciente();

            medico.nomeMedico = "Clodoaldo";
            medico.especialidadeMedico = "Oftalmologia";

            paciente.medico = medico;
            paciente.nomePaciente = "João";
            paciente.ExibirDados();
        }
        public class Medico
        {
            public string nomeMedico;
            public string especialidadeMedico;
        }
        public class Paciente
        {
            public string nomePaciente;
            public Medico medico;

            public void ExibirDados()
            {
                Console.WriteLine($"O paciente {nomePaciente} foi atendido pelo médico {medico.nomeMedico}, especialista em {medico.especialidadeMedico}.");
            }
        }
    }
}
