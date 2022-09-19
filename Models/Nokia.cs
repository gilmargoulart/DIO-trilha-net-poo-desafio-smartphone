namespace DesafioPOO.Models
{
    /// <summary>
    /// Classe Nokia
    /// </summary>
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }

        /// <summary>
        /// Ligar o Nokia
        /// </summary>
        public override void Ligar()
        {
            Console.WriteLine("Ligando Nokia...");
        }

        /// <summary>
        /// Receber ligação no Nokia
        /// </summary>
        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no Nokia...");
        }

        /// <summary>
        /// Instalar um aplicativo no Nokia
        /// </summary>
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Nokia.");
        }

        public override string ToString()
        {
            return $"Nokia {Modelo}, {Memoria}GB de memória. Número '{Numero}'.";
        }
    }
}
