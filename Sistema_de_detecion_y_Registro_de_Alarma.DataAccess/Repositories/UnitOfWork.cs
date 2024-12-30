using Microsoft.EntityFrameworkCore;
using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context) {
            _context = context;
            if (!context.Database.CanConnect())
            {
                context.Database.Migrate();
            }
        }
        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }

}
