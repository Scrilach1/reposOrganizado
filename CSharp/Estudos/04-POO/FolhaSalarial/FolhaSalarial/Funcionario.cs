using System;
using System.Globalization;

namespace funcionario
{ 
    public class Funcionario
    {
        private int id;
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            double SalarioLiquido;
            SalarioLiquido = SalarioBruto - Imposto;
            return SalarioLiquido;
        }


        public void AumentarSalario(double perc)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (perc / 100));
        }

        public override string ToString()
        {
            return Nome + ", " + "R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
