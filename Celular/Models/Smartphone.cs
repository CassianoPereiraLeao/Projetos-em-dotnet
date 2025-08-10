namespace Celular.Models;

public abstract class Smartphone
{
    public string number;
    private string phoneModel;
    private string IMEI;
    private int memoryCapacity;

    public Smartphone(string number, string phoneModel, string IMEI, int memoryCapacity)
    {
        this.number = number;
        this.phoneModel = phoneModel;
        this.IMEI = IMEI;
        this.memoryCapacity = memoryCapacity;
    }

    public void Call(string phoneNumber)
    {
        Console.WriteLine($"Chamando o número {phoneNumber}...");
    }

    public void RecieveCall(string phoneNumber)
    {
        Console.WriteLine($"Recebendo ligação do número {phoneNumber}...");
    }

    public abstract void InstallApp(string appName);
}