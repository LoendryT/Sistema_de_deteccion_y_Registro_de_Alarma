using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.Alerts
{
    public class AlertEntityTypeConfigurationBase
        : EntityTypeConfigurationBase<Alert>
    {
        public override void Configure(EntityTypeBuilder<Alert> builder)
        {
            
            builder.ToTable("Alerts");
            builder.Property(x => x.Priority)
                .HasConversion(
                l => Converters.FromPriority(l),
                r => Converters.ToPriority(r));
            builder.Property(x => x.Activity).HasConversion(
                l => Converters.FromActivity(l),
                r => Converters.ToActivity(r));
            base.Configure(builder);
            builder.OwnsOne(x => x.Variable);

        }
    }
}
