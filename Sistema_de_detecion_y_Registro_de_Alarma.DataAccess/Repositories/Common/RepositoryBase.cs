using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Common
{
    public abstract class RepositoryBase
    {
        protected ApplicationContext _context;
        protected RepositoryBase(ApplicationContext context) {
            _context = context;
        }
    }
}
