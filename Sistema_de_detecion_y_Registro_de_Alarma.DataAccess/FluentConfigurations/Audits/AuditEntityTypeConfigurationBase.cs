using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.Common;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.FluentConfigurations.Audits
{
    public class AuditEntityTypeConfigurationBase
       : EntityTypeConfigurationBase<Audit>
    {
        public override void Configure(EntityTypeBuilder<Audit> builder)
        {
            builder.ToTable("Audits");
            base.Configure(builder);
            builder.HasOne(x => x.Operator)
                .WithMany().HasForeignKey(x => x.Id);
            

        }
    }
}
