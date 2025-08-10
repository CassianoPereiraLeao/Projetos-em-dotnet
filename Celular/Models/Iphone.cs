namespace Celular.Models;

public class Iphone : Smartphone
{
    public Iphone(string number, string phoneModel, string IMEI, int memoryCapacity) : base(number, phoneModel, IMEI, memoryCapacity) { }

    public override void InstallApp(string appName){
        Console.WriteLine($"Instalando o aplicativo \"{appName}\" no Iphone");
    }
}