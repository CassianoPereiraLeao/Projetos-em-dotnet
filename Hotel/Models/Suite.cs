namespace Hotel.Models;

public class Suite
{
    private readonly string tipoDaSuite;
    private readonly int capacidadeDaSuite;
    private readonly decimal valorDaDiaria;

    public Suite(string tipoDaSuite, int capacidadeDaSuite, decimal valorDaDiaria)
    {
        this.tipoDaSuite = tipoDaSuite;
        this.capacidadeDaSuite = capacidadeDaSuite;
        this.valorDaDiaria = valorDaDiaria;
    }

    public string GetTipoDaSuite()
    {
        return tipoDaSuite;
    }

    public int GetCapacidadeDaSuite()
    {
        return capacidadeDaSuite;
    }

    public decimal GetValorDaDiaria()
    {
        return valorDaDiaria;
    }
}