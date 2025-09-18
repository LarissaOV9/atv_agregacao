using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorista motorista = new Motorista();
            Carro carro = new Carro();

            motorista.nomeMotorista = "Matias";
            motorista.cnhMotorista = 1234567;

            carro.motorista = motorista;
            carro.modeloCarro = "Onix Plus";
            carro.ExibirDados();
        }
        public class Motorista
        {
            public string nomeMotorista;
            public int cnhMotorista;
        }
        public class Carro
        {
            public string modeloCarro;
            public Motorista motorista;

            public void ExibirDados()
            {
                Console.WriteLine($"O carro de modelo {modeloCarro} foi dirigido pelo motorista {motorista.nomeMotorista}, cujo CNH é: {motorista.cnhMotorista}.");
            }
        }
    }
}
