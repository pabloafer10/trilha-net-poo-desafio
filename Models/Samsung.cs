namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Samsung.");
        }
    }
}