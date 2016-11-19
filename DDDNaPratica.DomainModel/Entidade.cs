using System.Collections.Generic;
using System.Security.Cryptography;

namespace DDDNaPratica.DomainModel
{
    public abstract class Entidade
    {
        public int Id { get; protected set; }

        public override bool Equals(object entidade)
        {
            var entidadeTmp = entidade as Entidade;

            if (ReferenceEquals(entidadeTmp, null))
                return false;

            if (ReferenceEquals(this, entidadeTmp))
                return true;

            if (GetType() != entidadeTmp.GetType())
                return false;

            if (Id == 0 || entidadeTmp.Id == 0)
                return false;

            return Id == entidadeTmp.Id;
        }
        
        public static bool operator ==(Entidade entidadeA, Entidade entidadeB)
        {
            if (ReferenceEquals(entidadeA, null) && ReferenceEquals(entidadeB, null))
                return true;

            if (ReferenceEquals(entidadeA, null) || ReferenceEquals(entidadeB, null))
                return false;

            return entidadeA.Equals(entidadeB);
        }
        
        public static bool operator !=(Entidade entidadeA, Entidade entidadeB)
        {
            return !(entidadeA == entidadeB);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
}
