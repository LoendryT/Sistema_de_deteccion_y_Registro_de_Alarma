using Microsoft.EntityFrameworkCore;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Alert;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Entities.Audit;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Field_operatpor;
using Sistema_de_deteccion_y_Registro_de_Alarma.Domain.ValueObjets.Variable;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.DataAccess.Contexts
{
    public class ApplicationContext : DbContext
    {
        #region Table
        /// <summary>
        /// Tabla de Operadores de Campo
        /// </summary>
        public Microsoft.EntityFrameworkCore.DbSet<FieldOperator>? FieldOperators { get; set; }
        /// <summary>
        /// Tabla de Alarmas
        /// </summary>
        public Microsoft.EntityFrameworkCore.DbSet<Alert>? Alerts { get; set; }
        /// <summary>
        /// Tabla de Eventos de auditorias
        /// </summary>
        public Microsoft.EntityFrameworkCore.DbSet<Audit>? Audits { get; set; }
        #endregion
        public ApplicationContext() { }
        public ApplicationContext(string connectionString) : base(GetOptions(connectionString)) { }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqliteDbContextOptionsBuilderExtensions.UseSqlite(new DbContextOptionsBuilder(),connectionString).Options;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
            base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

   modelBuilder.Entity<Alert>()
        .HasKey(a => a.Id); // Definir Id como clave primaria de Alert
    modelBuilder.Entity<Audit>()
        .HasKey(a => a.Id); // Definir Id como clave primaria de Audit
    modelBuilder.Entity<FieldOperator>()
        .HasKey(a => a.Id); // Definir Id como clave primaria de FieldOperator
        }
    


    }
}
