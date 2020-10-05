using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Admin:Empleado
    {
        
      
        public Admin(string nombre, string apellido, int dni, string password) : base( nombre,  apellido,  dni,  password)
        {

        }
             
        /// <summary>
        /// Asigna el descuento Acorde al tipo de Empleado
        /// </summary>
        public override void AsignarDescuento()
        {
            this.descuento = 5.5f;
        }
        /// <summary>
        /// Asigna permiso de Admin
        /// </summary>
        public override void PermisoAdmin()
        {
            this.admin = true;
        }
    }
}
