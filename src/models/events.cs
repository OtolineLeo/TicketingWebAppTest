namespace IngressosAPI.Models;

public class Event
{
    public int ID {get; set;}
    public string Nome {get; set;}
    public int CapacidadeTotal {get; set;}
    public DateTime DataEvento {get; set;}
    public decimal PrecoPadrao {get; set;}
}