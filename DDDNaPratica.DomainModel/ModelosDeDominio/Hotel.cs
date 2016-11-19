using System.Collections.Generic;
using System.Linq;

namespace DDDNaPratica.DomainModel
{
    public class Hotel : Entidade
    {
        private IList<Quarto> _Quartos;

        public Endereco Endereco { get; }
        public AgendaTelefonica AgendaTelefonica { get; }

        public IEnumerable<Quarto> Quartos { get { return _Quartos; }; }

        public void AdicionarQUarto(Quarto quarto)
        {
            if (!_Quartos.Contains(quarto))
                _Quartos.Add(quarto);
        }
    }
}