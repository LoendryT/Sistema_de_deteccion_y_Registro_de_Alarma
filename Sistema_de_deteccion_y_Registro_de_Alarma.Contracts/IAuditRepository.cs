using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Contracts
{
    public interface IAuditRepository
    {
        void AddAudit(Audit audit);
        Audit? GetAudit(Guid Id);
        IEnumerable<Audit>? GetAllAudits();
        void UpdateAudit(Audit audit);
        void DeleteAudit(Audit audit);
    }
}
