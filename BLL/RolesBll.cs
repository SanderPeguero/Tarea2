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
               // if (rol.RolId != (contexto.Roles.Find(rol.RolId)).RolId && rol.Descripcion != (contexto.Roles.Find(rol.RolId)).Descripcion)
               // {
                    contexto.Roles.Add(rol);
                    paso = contexto.SaveChanges() > 0;
              //  }

            }

            return paso;
        }

        //Reemplaza la descripcion de una clase Roles en la base de datos
        public static bool Editar(Roles Rol)
        {
            bool paso = false;

            using (var contexto = new Contexto())
            {
                contexto.Roles.Update(Rol);

                paso = contexto.SaveChanges() > 0;

            }

            return paso;
        }
        //Elimina de la base de datos una clase Roles
        public static bool Eliminar(int RolID)
        {
            bool paso = false;

            using (var contexto = new Contexto())
            {
                Roles eliminar = contexto.Roles.Find(RolID);
                contexto.Roles.Remove(eliminar);
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
