using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.FieldOperators
{
    public class FieldOperatorEntityTypeConfigurationBase :
        EntityTypeConfigurationBase<FieldOperator>
    {
        public override void Configure(EntityTypeBuilder<FieldOperator> builder)
        {
            builder.ToTable("Field Operators");
            builder.Property(x => x.Id);
            builder.Property(x => x.ID)
                .HasConversion(
                l => Converters.FromID(l),
                r => Converters.ToID(r)
                    );  
            base.Configure(builder);
        }

    }
}
