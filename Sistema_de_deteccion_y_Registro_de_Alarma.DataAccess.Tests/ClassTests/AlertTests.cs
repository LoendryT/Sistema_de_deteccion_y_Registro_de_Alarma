using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Alerts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Tests.Utilities;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Variable;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Tests.ClassTests
{
    [TestClass]
    public class AlertTests
    {
        private IAlertRepository _alertRepository ;
        private IUnitOfWork _unitOfWork ;
        public AlertTests ()
        {
            ApplicationContext context = new ApplicationContext (ConnectionStringProvider.GetConnectionString());
            _alertRepository = new AlertRepository (context);
            _unitOfWork = new UnitOfWork (context);
        }
        [DataRow(Priority.low,45,"l","k")]
      
        [TestMethod]
        public void CanAddAlert(Priority priority, float off,string name, string unit)
        {
            //Arrange
            Guid id = Guid.NewGuid ();
            Guid guidV = Guid.NewGuid ();
            DateTime biggining = DateTime.Now;
            DateTime end= DateTime.Now;
            Variable variable = new Variable(guidV,name,unit);
            Alert alert = new Alert(biggining,end,priority,variable,id);
            //Execute
            _alertRepository.AddAlert(alert);
            _unitOfWork.SaveChange();
            //Assert
           Alert? loaded = _alertRepository.GetAlert(id);
            Assert.IsNotNull(loaded);
        }
        [DataRow(0)]
        [TestMethod]
        public void CanGetAlert(int position)
        {
           // Arrange
           var alerts = _alertRepository.GetAllAlerts()?.ToList();
            Assert.IsNotNull(alerts);
            Assert.IsTrue(position < alerts.Count);
            Alert? alertToGet = alerts[position];
          //Execute
          Alert? loaded = _alertRepository.GetAlert(alertToGet.Id);
          // Assert
          Assert.IsNotNull(loaded);

        }

    }
}
