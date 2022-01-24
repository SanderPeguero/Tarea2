using System.Collections.Generic;
using System.Linq;

namespace Tarea2
{
    //Clase BLL
    public class RolesBll
    {
        //Inserta a la base de datos una clase Roles
        public static bool Insertar(Roles rol)
        {
            bool paso = false;

            using (var contexto = new Contexto())
            {
                contexto.Roles.Add(rol);
                paso = contexto.SaveChanges() > 0;

            }

            return paso;
        }

        //Reemplaza la descripcion de una clase Roles en la base de datos
        public static bool Editar(Roles RolViejo, Roles RolNuevo)
        {
            bool paso = false;

            using (var contexto = new Contexto())
            {
                contexto.Roles.Remove(RolViejo);
                contexto.Roles.Add(RolNuevo);

                paso = contexto.SaveChanges() > 0;

            }

            return paso; 
        }
        //Elimina de la base de datos una clase Roles
        public static bool Eliminar(Roles rol)
        {
            bool paso = false;

            using (var contexto = new Contexto())
            {
                contexto.Roles.Remove(rol);
                paso = contexto.SaveChanges() > 0;

            }

            return paso;
        }

        //Obtiene una lista de Roles de la base de datos
        public static List<Roles> GetLista()
        {
            using (var contexto = new Contexto())
            {
                return contexto.Roles.ToList();
            }
        }
    }

}
