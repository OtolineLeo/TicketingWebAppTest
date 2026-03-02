namespace IngressosAPI.Models;

public class Cupom
{
    public required string Codigo {get; set;}
    public decimal PorcentagemDesconto {get; set;}
    public decimal ValorMinimo {get; set;}
}