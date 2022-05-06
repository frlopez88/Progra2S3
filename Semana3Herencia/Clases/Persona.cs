using System;
namespace Semana3Herencia.Clases
{
    public class Persona
    {
        public string nombre { get; set; }
        public string identidad { get; set; }
        public string carrera { get; set; }
        public double peso { get; set; }

        public void comer(double pesoComida)
        {
            peso += pesoComida;
        }

    }
}
