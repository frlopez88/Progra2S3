using System;
namespace Semana3Herencia.Clases
{
    public class Circulo : FiguraGeometrica
    {

        public double radio { get; set; }

        public override void calcularArea()
        {
            //area = 3.1416 * (radio * radio);
            area = Math.PI * Math.Pow(radio, 2);
        }

        public override void calcularPerimetro()
        {
            perimetro = 2 * Math.PI * radio;
        }

    }
}
