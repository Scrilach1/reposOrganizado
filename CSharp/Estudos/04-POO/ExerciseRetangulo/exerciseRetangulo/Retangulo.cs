using System;

namespace Course
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
           double area = Largura * Altura;
            return area;
        }
        public double Perimetro()
        {
            double p = 2 * (Largura + Altura);
            return p;
        }

        public double Diagonal()
        {
            double d = Math.Sqrt((Largura * Largura) + (Altura * Altura));
            return d;
        }

        public override string ToString()
        {
            return
            "AREA: " + Area()
            + "\nPERÍMETRO: " + Perimetro()
            + "\nDIAGONAL: " + Diagonal();

        }

    }
}