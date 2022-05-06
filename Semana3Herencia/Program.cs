using System;
using Semana3Herencia.Clases;

namespace Semana3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor p1 = new Profesor("Fernando Lopez", "0801", "Diseño Web");

            Console.WriteLine(p1.GetNombre());

            p1.SetNombre("Fernando Raul Lopez Castro");

            Console.WriteLine(p1.GetNombre());

        }
    }
}
