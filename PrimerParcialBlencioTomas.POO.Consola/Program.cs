using PrimerParcialBlencioTomas.POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialBlencioTomas.POO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 1
            Console.WriteLine("PUNTO 1");
            Cono cono = new Cono(17, 5);
            Console.WriteLine($"Generatriz: {cono.GetGeneratriz():n2}");
            Console.WriteLine($"Area: {cono.GetArea():n2}");
            Console.WriteLine($"Volumen: {cono.GetVolumen():n2}");
            string infCono = cono.GetInformacionCono();
            Console.WriteLine($"Informacion Cono: {infCono}");
            Console.WriteLine("");
            Console.WriteLine("");
            //PUNTO 2
            Console.WriteLine("PUNTO 2");
            Console.WriteLine(ValidadorPatente.Validar("AAANNN"));
            Console.WriteLine(ValidadorPatente.GetTipo("AAANNN"));
            Console.WriteLine(ValidadorPatente.Validar("AANNNAA"));
            Console.WriteLine(ValidadorPatente.GetTipo("AANNNAA"));
            Console.WriteLine("");
            Console.WriteLine("");
            //PUNTO 3
            Console.WriteLine("PUNTO 3");
            //APARTADO (D)
            Kilometros km = 150.5;
            Kilometros km1 = new Kilometros();
            double asdkm = km1;
            Console.WriteLine($"Paso de double a km: {km.GetDistancia()}");
            Console.WriteLine($"Convierto el tipo km en double: {asdkm}");

            Millas millas = 150.5;
            Millas millas1 = new Millas();
            double asdmilla = millas1;
            Console.WriteLine($"Paso de double a millas: {millas.GetDistancia()}");
            Console.WriteLine($"Convierto el tipo milla en double: {asdmilla}");

            Yardas yardas = 150.5;
            Yardas yardas1 = new Yardas();
            double asdyarda = yardas1;
            Console.WriteLine($"Paso de double a millas: {yardas.GetDistancia()}");
            Console.WriteLine($"Convierto el tipo milla en double: {asdyarda}");

            Console.WriteLine("");
            Console.WriteLine("");

            //APARTADO F)
            Yardas yar1= new Yardas(15.15);
            Yardas yar2 = new Yardas(22.15);
            Console.WriteLine(yar1==yar2);
            Millas mill1 = new Millas(15.15);
            Millas mill2 = new Millas(15.15);
            Console.WriteLine(mill2 == mill1);
            Kilometros kilo1 = new Kilometros(15.15);
            Kilometros kilo2 = new Kilometros(15.15);
            Console.WriteLine(kilo2 == kilo1);

            Console.WriteLine("Sumas");
            Console.WriteLine(yar2.GetEquivalenteKm());
            Console.WriteLine(kilo1);
            Console.WriteLine(yar2+kilo1);




            Console.ReadLine();
        }
    }
}
