namespace DesafioPOO.Models
{
    /// <summary>
    /// Classe iPhone
    /// </summary>
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            
        }

        /// <summary>
        /// Ligar o iPhone
        /// </summary>
        public override void Ligar()
        {
            Console.WriteLine("Ligando iPhone...");
        }

        /// <summary>
        /// Receber ligação no iPhone
        /// </summary>
        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação no iPhone...");
        }

        /// <summary>
        /// Instalar um aplicativo no iPhone
        /// </summary>
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no iPhone.");
        }

        public override string ToString()
        {
            return $"iPhone {Modelo}, {Memoria}GB de memória. Número '{Numero}'.";
        }
    }
}
