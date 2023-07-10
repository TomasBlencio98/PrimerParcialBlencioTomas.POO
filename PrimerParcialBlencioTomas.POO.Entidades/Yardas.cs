using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBlencioTomas.POO.Entidades
{
    public class Yardas
    {
        private double distancia;

        public Yardas()
        {
            distancia = 100;
        }
        public Yardas(double distancia)
        {
            this.distancia = distancia;
        }

        public double GetDistancia()
        {
            return distancia;
        }

        public double GetEquivalenteKm()
        {
            return distancia * 1093.61;
        }

        public static implicit operator Yardas(double v)
        {
            return new Yardas(v);
        }

        public static implicit operator double(Yardas v)
        {
            return v.distancia;
        }

        public static bool operator ==(Yardas v1, Yardas v2)
        {
            return v1.distancia== v2.distancia;
        }
        public static bool operator !=(Yardas v1, Yardas v2)
        {
            return !(v1 == v2);
        }
    }
}
