namespace IngressosAPI.Models;

public class Reserva
{
    public int Id {get; set;}
    public required string UsuarioCpf {get; set;}
    public int EventoId {get; set;}
    public string? CupomUtilizado {get; set;}
    public decimal ValorPagoFinal {get; set;}

    // NÃO SEI SE USARÁ PORQUE USAREMOS DAPPER

    // public Usuario Usuario {get; set;}
    // public Evento Evento {get; set;}
    // public Cupom? Cupom {get; set;}
}