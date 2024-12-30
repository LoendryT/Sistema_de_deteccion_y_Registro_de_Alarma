using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Audits;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Tests.Utilities;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Tests.ClassTests
{
    [TestClass]
    public class AuditTests
    {
        private IAuditRepository _auditRepository;
        private IUnitOfWork _unitOfWork;
        public AuditTests()
        {
            ApplicationContext context = new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _auditRepository = new AuditRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }
        [DataRow("show","name",56786934)]
        [DataRow("shut", "name2", 59786934)]
        [TestMethod]
      public  void CanAddAudit(string action, string name, double telephone)
        {
            //Arrange
            Guid id = Guid.NewGuid();
            Guid idO = Guid.NewGuid();
            FieldOperator Operator = new FieldOperator(name, telephone, new Domain.Type.Identification(),idO);
            Audit audit = new Audit(new DateTime(12,2,4), Operator,action,id);
            //Execute
            _auditRepository.AddAudit(audit);
            _unitOfWork.SaveChange();
            //Assert
            Audit? loaded = _auditRepository.GetAudit(id);
            Assert.IsNotNull(loaded);
        }
    }
}
