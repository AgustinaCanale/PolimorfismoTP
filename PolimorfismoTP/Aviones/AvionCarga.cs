using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTP.Aviones
{
    public class AvionCarga : Avion
    {
        public AvionCarga(string piloto, double peso  ,string tipomercaderia  , string copiloto, string azafata) : base(piloto, copiloto, azafata)
        {

            Peso = peso;
            TipoMercaderia = tipomercaderia;
        }

        public double Peso { get; set; }
        public string TipoMercaderia { get; set; }


        public override string Despega()
        {
            return "El avión despegó con éxito a las 14:15";
        }


        public override string Aterriza()
        {
            return "Aterrizando en el aeropuerto del Palomar 19:30";
        }

        public override string ToString()
        {
            return base.Imprimir() + $"\nPeso del equipaje de avión: {Peso} kg" +
                $"\nTipo Mercadería: {TipoMercaderia}";
        }

    }
}
