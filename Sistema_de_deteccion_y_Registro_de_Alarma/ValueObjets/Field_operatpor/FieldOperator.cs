using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.Entity;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.ValueObjets;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor
{
    /// <summary>
    /// Modela un operario de campo  como una entidad
    /// </summary>
    public class FieldOperator : Entity
    {


        #region Properties

        public string FullName { get; set; }
        public double Telephone { get; set; }
        public Identification ID { get; } = new Identification();
        #endregion
        public FieldOperator(string fullName, double telefone, Identification identification,Guid id) : base(id)
        {

            FullName = fullName;
            Telephone = telefone;
            ID = identification;
        }
        protected FieldOperator() : base()
        {
            FullName = "Pepe";
            Telephone = 53535353;
            ID.Reset();
            
        }
        
    }
}
