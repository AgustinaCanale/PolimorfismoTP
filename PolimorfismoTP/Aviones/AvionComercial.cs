using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTP.Aviones
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string piloto, int capacidad, string lineaAerea, string copiloto, string azafata) : base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }


        public override string Despega()
        {
            return "El avión despegó con exito a las 22:32";
        }
        public override string Aterriza()
        {
            return "Aterrizando en el aeropuerto de Ezeiza a las 8:12";
        }

        

        public override string ToString()
        {
            return base.Imprimir() + $"\nLa capacidad de pasajeros es:  {Capacidad}" +
                $"\nLa linea aérea es: {LineaAerea}";
        }

        

    }
}

