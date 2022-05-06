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

            Alumno a1 = new Alumno() {
                nombre = "Lia Marcela",
                identidad = "0802",
                carrera = "Diseño Web"
            };

            Console.WriteLine("Nombre :" + a1.nombre + " Carrera " + a1.carrera);

            a1.carrera = "Diseño Grafico";

            Console.WriteLine("Nombre :" + a1.nombre + " Carrera " + a1.carrera);

        }
    }
}
