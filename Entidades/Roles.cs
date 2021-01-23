using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Registro_Roles.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Roles()
        {
            RolId = 0;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
