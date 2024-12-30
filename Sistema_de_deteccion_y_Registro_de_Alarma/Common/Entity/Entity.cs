using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Common.Entity
{
    public abstract class Entity
    {
       public Guid Id { get;} 
        public Entity(Guid id) { 
            Id = id;
        }
        public static bool AreEquals(Entity entity1, Entity entity2) => entity1.Id == entity2.Id;
        protected Entity() { }  
    }
}
