namespace Hotel.Models;

public class Reserva
{
    private List<Pessoa> hospedes = [];
    private Suite suite;
    private readonly int diasReservados;

    public Reserva(int diasReservados)
    {
        this.diasReservados = diasReservados;
    }

    public void CadastrarHospede(List<Pessoa> hospedes)
    {
        this.hospedes = hospedes;
    }

    public void ShowHospedes()
    {
        foreach (var hospede in hospedes)
        {
            Console.WriteLine(hospede);
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        this.suite = suite;
    }

    public int ObterQuantidadeDeHospedes()
    {
        return hospedes.Count;
    }

    public decimal CalcularValorDaDiaria()
    {
        return diasReservados * suite.GetValorDaDiaria();
    }
}
