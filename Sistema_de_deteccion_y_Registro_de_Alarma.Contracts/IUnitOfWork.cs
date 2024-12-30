using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Contracts
{
    public interface IUnitOfWork
    {
       public void SaveChange();
    }
}
