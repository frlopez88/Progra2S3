using System;
namespace Semana3Herencia.Clases
{
    public class Profesor
    {
        private string nombre;
        private string identidad;
        private string carrera;
        private int horas_trabajadas;

        public Profesor(string NombreParametro, string IdentidadParametro,
                         string CarreraParametro)
        {
            nombre = NombreParametro;
            identidad = IdentidadParametro;
            carrera = CarreraParametro;
            horas_trabajadas = 0;

        }

        /* Metodo Get es para retorna informacion de una Propiedad*/
        public string GetNombre() {
            return nombre;
        }

        /* Es para Actualizar Una Propiedad*/
        public void SetNombre(string NombreNuevo) {
            nombre = NombreNuevo;
        }

        public void ImpartirClases(int HorasTrabajadas) {

            horas_trabajadas = horas_trabajadas + HorasTrabajadas;

        }

        public string Saludar() {

            return "Hola mi nombre es " + nombre
                + ",  mis horas trabajadas son: " + horas_trabajadas;

        }



    }
}
