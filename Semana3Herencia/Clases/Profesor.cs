using System;
namespace Semana3Herencia.Clases
{
    public class Profesor : Persona
    {

        public int horas_trabajadas { get; set; }

        public void ImpartirClases(int HorasTrabajadas) {

            horas_trabajadas = horas_trabajadas + HorasTrabajadas;

        }

        public string Saludar() {

            return "Hola mi nombre es " + nombre
                + ",  mis horas trabajadas son: " + horas_trabajadas;

        }



    }
}
