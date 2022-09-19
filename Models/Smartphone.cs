namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        /// <summary>
        /// Número do telefone.
        /// </summary>
        public string Numero { get; set; }
        
        private string _modelo;

        /// <summary>
        /// Modelo do telefone.
        /// </summary>
        public string Modelo { get => _modelo; }

        private string _imei;

        /// <summary>
        /// IMEI do telefone.
        /// </summary>
        public string IMEI { get => _imei; }

        private int _memoria;

        /// <summary>
        /// Quantidade de memória em GB. Ex: 4
        /// </summary>
        public int Memoria { get => _memoria; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this._modelo = modelo;
            this._imei = imei;
            this._memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
