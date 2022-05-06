using System;
namespace Semana3Herencia.Clases
{
    public class Alumno
    {

        public string nombre { get; set; }
        public string identidad { get; set; }
        public string carrera { get; set; }
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
                return "El alumno "+nombre+" tiene derecho a examen";
            }
            else {
                return "El alumno "+nombre+" no tiene derecho a examen";
            }
        }

    }
}
