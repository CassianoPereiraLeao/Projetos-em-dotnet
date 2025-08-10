using Celular.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("1223333", "Nokia tijolão", "1111111111", 32);
        Console.WriteLine("Criando o Nokia: ");
        nokia.Call("1333111");
        nokia.InstallApp("Backyardgans");

        Console.WriteLine("");

        Smartphone iphone = new Iphone("1333111", "Iphone pro max 13", "1111112321312", 128);
        Console.WriteLine("Criando o iphone: ");
        iphone.RecieveCall("1223333");
        iphone.InstallApp("Whatsapp");
    }
}
