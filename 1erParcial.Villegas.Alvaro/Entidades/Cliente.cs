using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
      
        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido, int dni):base(nombre, apellido, dni)
        {
            
        }
        /// <summary>
        /// Asigna el descuento
        /// </summary>
        public override void AsignarDescuento()
        {
            if (this.Apellido == "Simpson")
                this.descuento = 13;
            else
                this.descuento = 0;
             
        }
        /// <summary>
        /// Busca un Cliente dentro de una lista de Clientes
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="clientes"></param>
        /// <returns>true si lo consigo, false si no se encuentra</returns>
        public static bool operator ==(Cliente cliente, List<Persona> clientes)
        {
            if (clientes.Contains(cliente))
                return true;

            return false;
        }
        public static bool operator !=(Cliente cliente, List<Persona> clientes)
        {
            return (!(cliente == clientes));
        }
        
        public override string ToString()
        {
            return $"{this.nombre} {this.apellido}   DNI:{this.dni}";
        }

    }
}
