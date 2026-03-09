using System;
using System.Globalization;

namespace Course
{

    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)

        {
            _nome = nome;
            _preco = preco;

        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value != " " && value != "")
                {

                    _nome = value;
                }
                else
                {
                    _nome = "Nome inválido";
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value != null)
                {
                    _preco = value;
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value != null)
                {
                    _quantidade = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            double ValTotal = _quantidade * _preco;
            return ValTotal;
        }
        public int AddProd(int qnt)
        {
            _quantidade = _quantidade + qnt;
            return _quantidade;
        }
        public int RemProd(int qnt)
        {
            _quantidade = _quantidade - qnt;
            return _quantidade;
        }
        public override string ToString()
        {
            return "Nome: " + _nome
                + ", R$" + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade em estoque: " + _quantidade
                + ", valor total em estoque R$" + ValorTotalEmEstoque();
        }
    }
}