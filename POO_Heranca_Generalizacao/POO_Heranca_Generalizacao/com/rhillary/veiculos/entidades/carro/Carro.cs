using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.carro
{
    internal class Carro : Veiculo
    {
        public int qtdPortas { get; set; }


        public Carro(string placa, string renavam, string modelo, int ano, int quantidadePortas)
            : base(placa, renavam, modelo, ano)
        {
            this.qtdPortas = quantidadePortas;
        }

        public Carro() { }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Quantidade de portas: {qtdPortas}\n");

        }
    }
}
