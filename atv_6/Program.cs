using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Empresa empresa = new Empresa();

            funcionario.nomeFuncionario = "Gabriel";
            funcionario.cargoFuncionario = "Faxineiro";

            empresa.funcionario = funcionario;
            empresa.nomeEmpresa = "Lacta";
            empresa.ExibirDados();
        }
        public class Funcionario
        {
            public string nomeFuncionario;
            public string cargoFuncionario;
        }
        public class Empresa
        {
            public string nomeEmpresa;
            public Funcionario funcionario;

            public void ExibirDados()
            {
                Console.WriteLine($"A empresa {nomeEmpresa} possui um funcionário chamado {funcionario.nomeFuncionario}, que ocupa o cargo de {funcionario.cargoFuncionario}.");
            }
        }
    }
}
