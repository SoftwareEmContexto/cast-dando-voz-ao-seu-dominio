namespace DDDNaPratica.DomainModel
{
    public class Quarto : Entidade
    {
        public int Numero { get; set; }
        public int Andar { get; set; }
        public int Corredor { get; set; }

        public bool ArCondicionado { get; set; }
        public bool TVLed { get; set; }
        public bool Banheiro { get; set; }
        public bool Frigobar { get; set; }
        public bool Wifi { get; set; }
        public bool CamaDeCasal { get; set; }
        public bool Varanda { get; set; }
    }
}
