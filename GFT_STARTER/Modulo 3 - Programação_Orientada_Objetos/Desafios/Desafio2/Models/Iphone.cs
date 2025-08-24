namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Instalando o aplicativo no IPHONE: {nomeApp}";
        }
    }
}