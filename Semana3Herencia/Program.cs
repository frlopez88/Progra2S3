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
            List<Cuadro> Lcuadro = new List<Cuadro>();
            List<Circulo> Lcirculo = new List<Circulo>();
            List<Triangulo> Ltriangulo = new List<Triangulo>();


            while (bandera == true)
            {

                Console.WriteLine(GetMenu());
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {

                    case 1:
                        // Creacion de Circulos
                        double data_radio;

                        Console.WriteLine("Ingrese el radio: ");
                        data_radio = Double.Parse(Console.ReadLine());                        

                        Circulo a1 = new Circulo() {
                            radio = data_radio
                        };

                        Lcirculo.Add(a1);

                        break;
                    case 2:
                        // Creacion de Cuadros
                        double data_ladoa;
                        double data_ladob;

                        Console.WriteLine("Ingrese Lado a: ");
                        data_ladoa = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese Lado b: ");
                        data_ladob = Double.Parse(Console.ReadLine());



                        Cuadro c1 = new Cuadro() {
                            ladoa = data_ladoa,
                            ladob = data_ladob
                        };

                        Lcuadro.Add(c1);

                        break;
                    case 3:
                        // Crear Triangulos Equila
                        double data_t_ladoa;

                        Console.WriteLine("Ingrese Lado A");
                        data_t_ladoa = Double.Parse(Console.ReadLine());

                        Triangulo t1 = new Triangulo() {
                            ladoa = data_t_ladoa
                        };

                        Ltriangulo.Add(t1);

                        break;
                    case 4:
                        // Reporte de Area de Circulos

                        Lcirculo.ForEach( delegate (Circulo x) {

                            x.calcularArea();
                            Console.WriteLine(x.area);

	                        });

                        break;
                    case 5:

                        // Reporte de Area de Cuadros

                        Lcuadro.ForEach(delegate (Cuadro x) {

                            x.calcularArea();
                            Console.WriteLine(x.area);

                        });

                        break;
                    case 6:

                        // Reporte de Area de Triangulos

                        Ltriangulo.ForEach(delegate (Triangulo x) {

                            x.calcularArea();
                            Console.WriteLine(x.area);

                        });

                        break;
                    case 7:
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

            return "1. Crear Circulo " + "\n"
                   + "2. Crear Cuadrado " + "\n"
                   + "3. Crear Triangulo " + "\n"
                   + "4. Reporte Area Circulos" + "\n"
                   + "5. Reporte Area Cuadrados " + "\n"
                   + "6. Reporte Area Triangulos " + "\n"
                   + "7. Salir";

        }
    }
}
