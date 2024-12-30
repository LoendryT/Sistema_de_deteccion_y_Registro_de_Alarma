using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.Entity;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Variable;
namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert
{/// <summary>
/// Modela una alarma de control de una variable
/// </summary>
    public class Alert : Entity
    {

        #region Properties 
        public DateTime BeginningDate { get; }
        public DateTime EndDate { get; }
        public Priority Priority { get; }
        public float OffRange { get;}
        public Variable Variable { get; }
        public Activity Activity { get; }

        #endregion

        public Alert(DateTime begginning, DateTime end, Priority priority, Variable variable,Guid Id):base(Id)
        {
            BeginningDate = begginning;
            EndDate = end;
            Priority = priority;
            Variable = variable;
        }
        protected Alert()
        {
            BeginningDate = DateTime.Now;
            EndDate = DateTime.Now;
            Priority = Priority.low;
            OffRange = 0;
            Variable = new Variable(Guid.NewGuid(), string.Empty, string.Empty);
        }

    }
}


