using System;

namespace Estacionamento.Models;

class Estacionament
{
    private int initialValue = 0;
    private int valuePerHour = 0;
    public void Run()
    {
        Console.WriteLine("Valor inicial do estacionamento: ");
        initialValue = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Valor da hora do estacionamento: ");
        valuePerHour = int.Parse(Console.ReadLine()!);

        Menu();
    }

    public void Menu()
    {
        var cars = new Veiculos();
        while (true)
        {
            Console.Clear();
            Console.Write("Digite a sua opção\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar\n> ");
            char option = char.Parse(Console.ReadLine()!);

            if (option == '1')
            {
                Console.WriteLine("Digite a placa do carro para adicionar: ");
                string sign = Console.ReadLine()!;
                cars.RegisterCar(sign);
                Console.ReadKey();
            }
            else if (option == '2')
            {
                Console.WriteLine("Digite a placa do carro para remover: ");
                string sign = Console.ReadLine()!;
                if (cars.RemoveCar(sign))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu: ");
                    int time = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Preço a pagar: R${PaymentValue(time)}");
                }
                Console.ReadKey();
            }
            else if (option == '3')
            {
                cars.ShowSigns();
                Console.WriteLine("Pressione enter para seguir");
                Console.ReadKey();
                continue;
            }
            else if (option == '4')
            {
                Console.WriteLine("Encerrando o sistema...");
                Thread.Sleep(2500);
                break;
            }
        }
    }

    public int PaymentValue(int time)
    {
        return initialValue + (time * valuePerHour);
    }
}
