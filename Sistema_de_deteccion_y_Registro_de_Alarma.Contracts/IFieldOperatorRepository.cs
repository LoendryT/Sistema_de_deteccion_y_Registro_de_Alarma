using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Contracts
{
    public interface IFieldOperatorRepository
    {
        void AddOperator(FieldOperator Oerator);
        FieldOperator? GetOperator(Guid Id);
        IEnumerable<FieldOperator> GetOperators();
        void UpdateOperator(FieldOperator Operator);
        void DeleteOperator(FieldOperator Operator);
    }
}
