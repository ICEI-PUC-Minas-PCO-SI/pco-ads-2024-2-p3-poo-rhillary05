using POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.carro;
using POO_Heranca_Generalizacao.com.rhillary.veiculos.entidades.moto;
using System;

namespace POO_Heranca_Generalizacao.com.rhillary.veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan1 = new Sedan("ABC-1234", "123456789", "Corolla", 2020, 4, 500);
            Sedan sedan2 = new Sedan("DEF-5678", "987654321", "Civic", 2021, 4, 450);

            Picape picape1 = new Picape("GHI-9012", "112233445", "Ranger", 2019, 4, 1000);
            Picape picape2 = new Picape("JKL-3456", "556677889", "S10", 2018, 4, 1200);

            Scooter scooter1 = new Scooter("MNO-7890", "998877665", "NMax", 2022, true, 200);
            Scooter scooter2 = new Scooter("PQR-1234", "443322110", "PCX", 2023, true, 180);

            Motocross motocross1 = new Motocross("STU-5678", "667788990", "KX450", 2021, false, "Alta Performance");
            Motocross motocross2 = new Motocross("VWX-9012", "110022334", "CRF450R", 2020, false, "Profissional");

            sedan1.Mostrar();
            sedan2.Mostrar();
            picape1.Mostrar();
            picape2.Mostrar();
            scooter1.Mostrar();
            scooter2.Mostrar();
            motocross1.Mostrar();
            motocross2.Mostrar();
        }
    }
}
