using System;
using System.Globalization;

namespace AlunoClass
{

    public class Aluno
    {
        public Aluno(string nome)
        {
            if (nome != null && nome != "")
            {
                this.nome = nome;
            }
        }
        public string nome;
        public double nota1, nota2, nota3;

        public double notafinal() 
        {
            double resultado = nota1 + nota2 + nota3;
            return resultado;
        }
        public void resultado()
        {
            if (notafinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double aprovado = 60;
                aprovado = aprovado - notafinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM " + aprovado + " PONTOS");
            }
        }
    }
}