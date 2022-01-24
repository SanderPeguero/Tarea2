using System;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Tarea2
{
    //Clase Roles
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public string? FechaCreacion { get; set; }

        public void SetFechaCreacion(string fecha){
            FechaCreacion = fecha;
        }
        public string? Descripcion { get; set; }
        public Roles(string descripcion)
        {
           // this.FechaCreacion = time;
            this.Descripcion = descripcion;
        }
    }

}
