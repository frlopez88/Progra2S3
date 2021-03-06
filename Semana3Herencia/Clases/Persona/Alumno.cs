using System;
namespace Semana3Herencia.Clases
{
    public class Alumno : Persona
    {

        public int faltas { get; set; } = 0;
        public bool esta_con_derecho { get; set; } = true;

        public void FaltarClase() {
            //faltas = faltas + 1;
            faltas += 1;

            if (faltas >= 8) {
                esta_con_derecho = false;
            }
        }


        public string GetReporteDerecho() {

            if (esta_con_derecho == true)
            {
                return "El alumno "+nombre+" tiene derecho a examen, tiene "+faltas+ " faltas";
            }
            else {
                return "El alumno "+nombre+ " no tiene derecho a examen, tiene " + faltas + " faltas";
            }
        }

    }
}
