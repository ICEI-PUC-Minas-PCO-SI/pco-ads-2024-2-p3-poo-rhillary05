using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades
{
    internal class Veiculo
    {
        public string placa { get; set; }

        public string renavam { get; set; }

        public string modelo { get; set; }

        public int ano { get; set; }

        public Veiculo(string placa, string renavam, string modelo, int ano)
        {
            this.placa = placa;
            this.renavam = renavam;
            this.modelo = modelo;
            this.ano = ano;
        }

        public Veiculo() { }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Placa: {placa} \nModelo {modelo} \nAno:{ano}  \nRenavam: {renavam}");
        }
    }
}
