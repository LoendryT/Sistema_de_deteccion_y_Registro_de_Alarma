using Microsoft.EntityFrameworkCore;
using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Alerts
{
    public class AlertRepository
        :RepositoryBase, IAlertRepository
    {
        public AlertRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddAlert(Alert alert)
        {
            _context.Alerts?.Add(alert);
        }
        public Alert? GetAlert(Guid Id) {
            return _context.Alerts?.FirstOrDefault(x => x.Id == Id);
        }
        public IEnumerable<Alert>? GetAllAlerts()
        {
            return _context.Alerts?.ToList();
        }
        public void UpdateAlert(Alert alert)
        {
            _context.Alerts?.Update(alert);
        }
        public void DeleteAlert (Alert alert)
        {
            _context.Alerts?.Remove(alert);
        }


    }
}
