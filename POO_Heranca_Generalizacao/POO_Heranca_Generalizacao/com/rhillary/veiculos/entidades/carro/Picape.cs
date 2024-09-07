using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.carro
{
    internal class Picape : Carro
    {
        public int capacidadeCarga { get; set; }

        public Picape() { }

        public Picape(string placa, string renavam, string modelo, int ano, int quantidadePortas, int capacidadeCarga)
            : base(placa, renavam, modelo, ano, quantidadePortas)
        {
            this.capacidadeCarga = capacidadeCarga;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Tipo: Picape \nCapacidade de Carga: {capacidadeCarga} kg");
            base.Mostrar();

        }
    }
}
