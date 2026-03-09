using System;
namespace esfera
{
    public class Esfera
    {
        public Esfera() { }
        public double Raio;
        public double Pi = 3.14;

        public double Circunferencia()
        {
            double circunferencia;
            circunferencia = (Raio * 2.00) * Pi;
            return circunferencia;
        }

        public double Volume()
        {
            double x;
            x = 4 / 3 * Pi * (Math.Cbrt(Raio));
            return x;
        }
    }
}

