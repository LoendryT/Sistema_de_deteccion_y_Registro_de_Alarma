using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.ValueObjets
{
   public abstract class ValueObjet
    {
        protected abstract IEnumerable<object> GetEqualityComponents();
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }
            var other = (ValueObjet)obj;
            return this.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
