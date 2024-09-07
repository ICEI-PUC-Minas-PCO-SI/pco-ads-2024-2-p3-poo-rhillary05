using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.moto
{
    internal class Motocross : Moto
    {
        public string suspensao { get; set; }

        public Motocross(string placa, string renavam, string modelo, int ano, bool garupa, string suspensao)
            : base(placa, renavam, modelo, ano, garupa)
        {
            this.suspensao = suspensao;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Tipo: Motocross \nTipo Suspensão: {suspensao}");
            base.Mostrar();
        }
    }
}
