namespace ApiBoletos.Models;

public class Boleto
{
    public int Id { get; set; }

    public string Sacado { get; set; }

    public decimal Valor { get; set; }

    public DateTime DataVencimento { get; set; }

    public bool Pago { get; set; }

    public DateTime? DataPagamento { get; set; }
}