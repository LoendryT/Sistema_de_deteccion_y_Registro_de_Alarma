using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Contracts
{
    public interface IAlertRepository
    {
        void AddAlert(Alert alert);
        Alert? GetAlert(Guid Id);
        IEnumerable<Alert>? GetAllAlerts();
        void UpdateAlert(Alert alert);
        void DeleteAlert(Alert alert);
    }
}
