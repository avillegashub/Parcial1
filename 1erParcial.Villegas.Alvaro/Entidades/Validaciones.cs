using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        

        public static bool NombreEnLista( string nombre)
        {
            foreach (Producto producto in Establecimiento.Productos)
            {
                if(producto.NombreProducto == nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool DniPersonaEnLista( int dniPersona)
        {
            foreach (Persona persona in Establecimiento.Clientes)
            {
                if( persona.Dni == dniPersona)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CodigoEnLista( int codigo)
        {
            foreach (Producto producto in Establecimiento.Productos)
            {
                if(producto.IdProducto == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CodigoPerteneceANombre(int codigo, string nombre)
        {

            foreach (Producto item in Establecimiento.Productos)
            {
                if (item.IdProducto == codigo && item.NombreProducto == nombre)
                    return true;
            }


            return false;
        }
        
    }
}
