namespace Celular.Models;

public class Nokia : Smartphone
{
    public Nokia(string number, string phoneModel, string IMEI, int memoryCapacity) : base(number, phoneModel, IMEI, memoryCapacity) { }

    public override void InstallApp(string appName)
    {
        Console.WriteLine($"Instalando o aplicativo \"{appName}\" no Nokia");
    }
}
