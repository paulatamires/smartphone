namespace DesafioPOO.Models
{
    public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Ligando o celular");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo uma ligação");
    }

    public abstract void InstalarAplicativo(string nome);
}
}