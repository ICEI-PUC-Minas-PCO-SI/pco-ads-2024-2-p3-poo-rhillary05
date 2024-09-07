using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.carro
{
    internal class Sedan: Carro
    {
        public int capacidadeMala { get; set; }

        public Sedan(string placa, string renavam, string modelo, int ano, int quantidadePortas, int capacidadePortaMalas)
            : base(placa, renavam, modelo, ano, quantidadePortas)
        {
            this.capacidadeMala = capacidadeMala;
        }

        public Sedan() { }

        public override void Mostrar()
        {
            Console.WriteLine($"Tipo: Sedan \nCapacidade do Porta-Malas: {capacidadeMala} litros");
            base.Mostrar();
        }

    }
}
