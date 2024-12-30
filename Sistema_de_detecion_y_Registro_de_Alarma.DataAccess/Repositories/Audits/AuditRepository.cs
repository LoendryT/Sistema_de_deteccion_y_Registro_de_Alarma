using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Audits
{
    public class AuditRepository: RepositoryBase, IAuditRepository
    {
        public AuditRepository(ApplicationContext context): base(context)
        {
        }
       public void AddAudit(Audit audit)
        {
            _context.Audits?.Add(audit);
        }
        public Audit? GetAudit(Guid Id)
        {
            return _context.Audits?.FirstOrDefault(x => x.Id == Id);
        }
       public IEnumerable<Audit>? GetAllAudits()
        {
            
            return _context.Audits?.ToList();
        }
       public void UpdateAudit(Audit audit)
        {
            _context.Audits?.Update(audit);
        }
       public void DeleteAudit(Audit audit)
        {
            _context.Audits?.Remove(audit);
        }

    }
}
