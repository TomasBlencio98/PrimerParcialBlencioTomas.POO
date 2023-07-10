using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBlencioTomas.POO.Entidades
{
    public class Millas
    {
        private double distancia;
        public double GetDistancia()
        {
            return distancia;
        }

        public double GetEquivalenteKm()
        {
            return distancia * 0.621371;
        }

        public Millas()
        {
            distancia = 100;
        }
        public Millas(double distancia)
        {
            this.distancia = distancia;
        }

        public static implicit operator Millas(double v)
        {
            return new Millas(v);
        }

        public static implicit operator double(Millas v)
        {
            return v.distancia;
        }
        public static bool operator ==(Millas v1, Millas v2)
        {
            return v1.distancia == v2.distancia;
        }
        public static bool operator !=(Millas v1, Millas v2)
        {
            return !(v1 == v2);
        }
    }
}
