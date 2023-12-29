namespace DesafioPOO.Models
{
public class Nokia : Smartphone
{
    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no Nokia");
    }
}
}