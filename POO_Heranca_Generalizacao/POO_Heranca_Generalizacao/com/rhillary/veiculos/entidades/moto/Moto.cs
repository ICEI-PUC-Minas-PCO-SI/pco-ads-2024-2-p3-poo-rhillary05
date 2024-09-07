using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.moto
{
    internal class Moto : Veiculo
    {
        public bool garupa { get; set; }

        public Moto(string placa, string renavam, string modelo, int ano, bool garupa)
            : base(placa, renavam, modelo, ano)
        {
            this.garupa = garupa;
        }

        public Moto() { }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Garupa: {(garupa ? "Sim" : "Não")} \n");
        }

    }
}
