using Hotel.Models;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa(nome: "Hóspede 1", sobrenome: "Sla");
        Pessoa p2 = new Pessoa(nome: "Hóspede 2", sobrenome: "Ok");

        hospedes.Add(p1);
        hospedes.Add(p2);

        // Cria a suíte
        Suite suite = new(tipoDaSuite: "Premium", capacidadeDaSuite: 2, valorDaDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new(5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospede(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
        Console.WriteLine($"Valor Total: {reserva.CalcularValorDaDiaria()}");
    }
}
