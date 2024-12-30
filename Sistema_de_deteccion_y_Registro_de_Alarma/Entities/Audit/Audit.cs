using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.Entity;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit
{
    /// <summary>
    /// Modela un evento de auditoria 
    /// </summary>
    public class Audit : Entity
    {
        #region Properties
        public DateTime Beginning { get;  }
        public FieldOperator Operator { get;  }
        public string Message { get; }
        #endregion
        /// <summary>
        /// Genera un mensaje que ofrece informacion sobre lo feccha , el operador de campo y la accion realizada
        /// </summary>
        /// <param name="beginning"></param>
        /// <param name="operator_"></param>
        /// <param name="action"></param>
        public Audit(DateTime beginning, FieldOperator operator_, string action,Guid id): base(id)
        {
            Beginning = beginning;
            Operator = operator_;
            Message = action + "\n" + beginning.ToString() + "\n" + Operator.FullName;
        }
        protected Audit()
        {
            Beginning = DateTime.Now;
            Operator = new FieldOperator("Pepe Perez Perez", 53535353, new Identification(),Guid.NewGuid());
            Message = "Observar Variable" + "\n" + Beginning.ToString() + "\n" + Operator.FullName;
        }

    }
}
