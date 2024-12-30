using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.Entity;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.ValueObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <sumary>
/// Modela una variable fisica
/// </sumary>
namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Variable
{
    public class Variable : ValueObjet
    {
        #region Properties
        public string Name { get; set; }
        public string Measuremnet_unit { get; }
        public Guid Code { get; set; }
        #endregion
        protected Variable() : base()
        {
            Name = string.Empty;
            Measuremnet_unit = string.Empty;
        }
        public Variable(Guid code, string name, string unit) : base()
        {
            Name = name;
            Measuremnet_unit = unit;
            Code = code;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Measuremnet_unit;
            yield return Code;
        }

    }
}
