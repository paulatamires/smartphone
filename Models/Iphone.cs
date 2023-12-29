namespace DesafioPOO.Models
{
public class Iphone : Smartphone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no Iphone");
    }
}
}