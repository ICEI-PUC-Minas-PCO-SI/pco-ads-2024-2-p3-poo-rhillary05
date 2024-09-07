using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.moto
{
    internal class Scooter : Moto
    {
        public int autonomia { get; set; }

        public Scooter() { }

        public Scooter(string placa, string renavam, string modelo, int ano, bool garupa, int autonomia)
            : base(placa, renavam, modelo, ano, garupa)
        {
            this.autonomia = autonomia;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Tipo: Scooter \nAutonomia: {autonomia} km");
            base.Mostrar();
        }
    }
}
