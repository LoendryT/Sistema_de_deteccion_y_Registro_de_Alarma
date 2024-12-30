using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_deteccion_y_Registro_de_Alarma.Domain.Type
{
    /// <summary>
    /// Clase de tipo static para relizar las converciones
    /// </summary>
    public static class Converters
    {
        public static string FromPriority(Priority element)
        {
            if (element == Priority.low)
                return "Low";
            if (element == Priority.middle)
                return "Middle";
            return "High";

        }
        public static Priority ToPriority(string element)
        {
            if (element == FromPriority(Priority.low))
                return Priority.low;
            if (element == FromPriority(Priority.middle))
                return Priority.middle;
            return Priority.high;

        }
        public static string FromActivity(Activity element)
        {
            if (element == Activity.active)
                return "Active";
            return "Inactive";

        }
        public static Activity ToActivity(string element)
        {
            if (element == FromActivity(Activity.active))
                return Activity.active;
            return Activity.inactive;

        }
        public static Identification ToID(string element)
        {
            byte[] bytes = new byte[11];
            
            for (int i = 0; i < element.Length; i++)
            { 
                bytes[i] = Convert.ToByte(element[i]);
            }
            Identification newId = new Identification(bytes);
            return newId ;
        }
        public static string FromID(Identification element) => element.GetDigits();
    }
}
