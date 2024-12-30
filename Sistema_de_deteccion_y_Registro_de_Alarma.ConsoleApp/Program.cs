using Microsoft.EntityFrameworkCore;
using Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Variable;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext context = new ApplicationContext("Data Source=Sistema_de_deteccion_y_Registro_de_AlarmaDB.sqlite");
            if (context.Database.CanConnect())
                context.Database.Migrate();

            // instancias de ejemplo
            Identification  identification = new Identification();
            Variable  variable1 = new Variable(Guid.NewGuid(),"Presion","Pa");
            FieldOperator operator1 = new FieldOperator("Pepe",53545657,identification,Guid.NewGuid());
            Alert alert1 = new Alert(DateTime.Now, DateTime.Now, Domain.Type.Priority.low, variable1,Guid.NewGuid());
            Audit audit1 = new Audit(DateTime.Now, operator1, "revizar alarma",Guid.NewGuid());
            context.Alerts?.Add(alert1);
            context.Audits?.Add(audit1);
            context.FieldOperators?.Add(operator1);
            context.SaveChanges();
            FieldOperator? operatorFromAudit = context
                .Set<FieldOperator>()
                .First(v => v.Id == audit1.Operator.Id);
             
        }

    }
}
