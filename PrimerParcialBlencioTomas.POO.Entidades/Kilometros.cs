using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBlencioTomas.POO.Entidades
{
    public class Kilometros
    {
        private double distancia;

        public double GetDistancia()
        {
            return distancia;   
        }

        public Kilometros()
        {
            distancia = 100;
        }
        public Kilometros(double distancia)
        {
            this.distancia = distancia;
        }

        public static implicit operator Kilometros(double v)
        {
            return new Kilometros(v);
        }

        public static implicit operator double(Kilometros kilometros)
        {
            return kilometros.distancia;
        }
        public static bool operator ==(Kilometros k1 , Kilometros k2)
        {
            return k1.distancia== k2.distancia;
        }
        public static bool operator !=(Kilometros k1, Kilometros k2)
        {
            return !(k1 == k2);
        }

        public static double operator +(Kilometros k1, Millas m1)
        {
            return k1.distancia + m1.GetDistancia()* 0.621371;
        }
        public static double operator +(Kilometros k1, Yardas y1)
        {
            return k1.distancia+y1.GetEquivalenteKm();
        }

    }
}
