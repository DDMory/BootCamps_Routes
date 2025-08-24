namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Ligar()
        {
            return "Ligando...";
        }

        public string ReceberLigacao()
        {
            return "Recebendo ligação...";
        }

        public abstract string InstalarAplicativo(string nomeApp);
    }
}