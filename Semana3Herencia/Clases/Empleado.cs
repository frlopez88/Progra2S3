using System;
namespace Semana3Herencia.Clases
{
    public class Empleado : Persona
    {

        public double salario { get; set; }

        public virtual double GetPago() {
            // Al hacer virtual el metodo
            // Se le dice a C# que este metodo puede ser sobre escrito en sus clases
            // hijas

            return salario;
        }

    }
}
