using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();

            cliente.nomeCliente = "Ronaldo";
            cliente.cpfCliente = "246-369-123-80";

            pedido.cliente = cliente;
            pedido.numeroPedido = 35;
            pedido.ExibirDados();
        }
        public class Cliente
        {
            public string nomeCliente;
            public string cpfCliente;
        }
        public class Pedido
        {
            public int numeroPedido;
            public Cliente cliente;

            public void ExibirDados()
            {
                Console.WriteLine($"O pedido de número {numeroPedido} foi comprado por {cliente.nomeCliente}, cujo cpf é: {cliente.cpfCliente}.");
            }
        }
    }
}
