using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBlencioTomas.POO.Entidades
{
    public static class ValidadorPatente
    {
        public static bool Validar(string patente)
        {
            if(patente==null) 
            {
                return false;
            }
            if (patente.Length ==6 || patente.Length==7)
            {
                return true;
            }
            return false;
        }

        private static string TipoFormato(string patente)
        {
            string tipo;
            switch (patente.Length)
            {
                case 6:
                    tipo = "Patente vieja";
                    break;
                case 7:
                    tipo = "Patente nueva";
                    break;
                default:
                    tipo = "Ninguno";
                    break;
            }
            return tipo;
        }

        public static string GetTipo(string patente)
        {
            return TipoFormato(patente);
        }
    }
}
