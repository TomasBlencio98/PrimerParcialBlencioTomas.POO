using System;

namespace PrimerParcialBlencioTomas.POO.Entidades
{
    public class Cono
    {
        private double generatriz;
        private int altura;
        private int radioDeGiro;

        public Cono(int altura, int radioDeGiro)
        {
          
            this.altura = altura;
            this.radioDeGiro = radioDeGiro;
            this.generatriz = GetGeneratriz();
            
            //FALTA CONTROLAR, NOSE COMO 
        }


        public double GetGeneratriz()
        {
            return Math.Sqrt((Math.Pow(altura, 2) + Math.Pow(radioDeGiro, 2)));
        }
        
        public double GetArea()
        {
            return Math.PI*radioDeGiro*(radioDeGiro+GetGeneratriz());
        }

        public double GetVolumen()
        {
            return (Math.PI * Math.Pow(radioDeGiro, 2) * altura) / 3;
        }

        public  string GetInformacionCono()
        {
            return $"Generatriz:{GetGeneratriz()}/ " +
                $"Radio:{radioDeGiro}/ Altura:{altura}";
        }


    }
}
