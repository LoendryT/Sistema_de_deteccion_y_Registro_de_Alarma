using Sistema_de_deteccion_y_Registro_de_Alarma.Contracts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Repositories.FieldOperators
{
    public class FieldOperatorRepository: RepositoryBase, IFieldOperatorRepository
    {
        public FieldOperatorRepository(ApplicationContext context) : base(context)
        {
         }
         public void AddOperator(FieldOperator Oerator)
         {
             _context.FieldOperators?.Add(Oerator);
         }

         public FieldOperator? GetOperator(Guid Id)
         {
            return _context.FieldOperators?.FirstOrDefault(o => o.Id == Id);
         }
         public   IEnumerable<FieldOperator>? GetOperators()
         {
            return _context.FieldOperators?.ToList();
         }
         public void UpdateOperator(FieldOperator Operator)
         {
            _context.FieldOperators?.Update(Operator);
         }
         public  void DeleteOperator(FieldOperator Operator)
          {
            _context.Remove(Operator);
          }

    }
 }

