using System;
using System.Collections.Generic;
using Semana3Herencia.Clases;

namespace Semana3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor p1 = new Profesor()
            {
                nombre = "Fernando Lopez",
                identidad = "0801",
                carrera = "Diseño Web",
                peso = 190,
                salario = 100

            };

            Profesor p2 = new Profesor() {
                nombre = "Carlo Ancheloti",
                identidad = "0803",
                carrera = "Futbol",
                peso = 200,
                salario = 100 
            };

            Empleado e1 = new Empleado()
            {
                nombre = "Luis Lopez",
                identidad="0901",
                carrera = "Psicologia",
                salario = 10000
            };

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

            p1.ImpartirClases(10);
            p2.ImpartirClases(10);

            p1.comer(2);
            p2.comer(3);

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
                Console.WriteLine(x.peso);

                Console.WriteLine(x.GetPago());
            });

            Console.WriteLine( "Pago de Empleado "+ e1.nombre + "= " +e1.GetPago());

        }
    }
}
