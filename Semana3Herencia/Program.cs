using System;
using System.Collections.Generic;
using Semana3Herencia.Clases;

namespace Semana3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor p1 = new Profesor("Fernando Lopez", "0801", "Diseño Web");

            Profesor p2 = new Profesor("Carlo Ancheloti", "0803", "Futbol");

            Alumno a1 = new Alumno() {
                nombre = "Lia Marcela",
                identidad = "0802",
                carrera = "Diseño Web"
            };

            Alumno a2 = new Alumno()
            {
                nombre = "Hector Miranda",
                identidad = "0804",
                carrera = "Diseño Web"
            };

            Alumno a3 = new Alumno()
            {
                nombre = "Claudia Sanchez",
                identidad = "0805",
                carrera = "Diseño Web"
            };

            Alumno a4 = new Alumno()
            {
                nombre = "Israel Martinez",
                identidad = "0806",
                carrera = "Diseño Web"
            };

            for (int i = 0; i < 8; i++) {
                a2.FaltarClase();
            }

            List<Alumno> La = new List<Alumno>();
            List<Profesor> Lp = new List<Profesor>();

            La.Add(a1);
            La.Add(a2);
            La.Add(a3);
            La.Add(a4);

            Lp.Add(p1);
            Lp.Add(p2);

            La.ForEach(delegate (Alumno x)
            {
                Console.WriteLine(x.GetReporteDerecho());

            });

            Lp.ForEach(delegate (Profesor x)
            {
                Console.WriteLine(x.Saludar());
            });

        }
    }
}
