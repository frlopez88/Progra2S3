using System;
using System.Collections.Generic;
using Semana3Herencia.Clases;

namespace Semana3Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            int opcion;
            List<Alumno> La = new List<Alumno>();
            List<Profesor> Lp = new List<Profesor>();


            while (bandera == true)
            {

                Console.WriteLine(GetMenu());
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {

                    case 1:
                        // Creacion de Alumnos
                        string n;
                        string id;
                        string c;
                        double p;

                        Console.WriteLine("Ingrese Nombre: ");
                        n = Console.ReadLine();

                        Console.WriteLine("Ingrese Identidad: ");
                        id = Console.ReadLine();

                        Console.WriteLine("Ingrese Carrera: ");
                        c = Console.ReadLine();

                        Console.WriteLine("Ingrese Peso de Alumno: ");
                        p = Double.Parse(Console.ReadLine());

                        Alumno a1 = new Alumno() {
                            nombre = n,
                            identidad = id,
                            carrera = c,
                            peso = p
                        };

                        La.Add(a1);

                        break;
                    case 2:
                        // Creacion de Profesores
                        string n1;
                        string id1;
                        string c1;
                        double p1;

                        Console.WriteLine("Ingrese Nombre: ");
                        n1 = Console.ReadLine();

                        Console.WriteLine("Ingrese Identidad: ");
                        id1 = Console.ReadLine();

                        Console.WriteLine("Ingrese Carrera: ");
                        c1 = Console.ReadLine();

                        Console.WriteLine("Ingrese Peso de Alumno: ");
                        p1 = Double.Parse(Console.ReadLine());

                        Profesor prf1 = new Profesor() {
                            nombre = n1,
                            identidad = id1,
                            carrera = c1,
                            peso = p1
                        };

                        Lp.Add(prf1);

                        break;
                    case 3:
                        // Registrar Falta de Alumno
                        string IdBusqueda;

                        Console.WriteLine("Ingrese Identidad de Alumno a Registrar Falta");
                        IdBusqueda = Console.ReadLine();

                        La.ForEach(delegate (Alumno x)  {

                            if (IdBusqueda == x.identidad)
                            {
                                x.FaltarClase();
                            }
                            else {

                                Console.WriteLine("Identidad no encontrada");
                            }


	                    });

                        break;
                    case 4:
                        Console.WriteLine("Ingrese Identidad del Docente a Registrar Horas de Trabajo");
                        String IdBusqueda2 = Console.ReadLine();

                        Console.WriteLine("Ingrese Horas de Trabajo");
                        int Horas = int.Parse(Console.ReadLine());

                        Lp.ForEach( delegate (Profesor x) {

                            if (IdBusqueda2 == x.identidad) {
                                x.ImpartirClases(Horas);
                            }
                            else
                            {

                                Console.WriteLine("Identidad no encontrada");
                            }


	                        });

                        break;
                    case 5:

                        La.ForEach(delegate (Alumno x)
                        {

                            Console.WriteLine(x.GetReporteDerecho());

                        });

                        break;
                    case 6:

                        bandera = false;
                        break;
                    default:
                        break;

                }

                // Es importante identificar si cierra el ciclo
                // cambiando la bandera

            }




        }


        public static string GetMenu()
        {

            return "1. Crear Alumnos " + "\n"
                   + "2. Crear Docentes " + "\n"
                   + "3. Registrar Falta de Alumnos " + "\n"
                   + "4. Registrar Horas Clase Docente" + "\n"
                   + "5. Generar Reporte de Alumnos "+"\n"
                   + "6. Salir";

        }
    }
}
