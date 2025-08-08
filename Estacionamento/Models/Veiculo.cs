using System.Runtime.CompilerServices;

namespace Estacionamento.Models;

class Veiculos
{
    private List<string> signs = [];
    public void ShowSigns()
    {
        foreach (var sign in signs)
        {
            Console.WriteLine(sign);
        }
    }

    public void RegisterCar(string sign)
    {
        foreach (var signCar in signs)
        {
            if (signCar.Equals(sign))
            {
                Console.WriteLine("Esse carro já está no estacionamento");
                return;
            }
        }
        signs.Add(sign.ToUpper());
        Console.WriteLine("Veiculo adicionado com sucesso!");
    }

    public bool RemoveCar(string sign)
    {
        foreach (string signCar in signs)
        {
            if (signCar.Equals(sign))
            {
                signs.Remove(sign.ToUpper());
                return true;
            }
        }
        Console.WriteLine("Nenhum carro encontrado com essa placa");
        return false;
    }
}