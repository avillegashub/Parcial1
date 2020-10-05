using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected float descuento;

        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public int Dni
        {
            get { return dni; }
        }
        public float Descuento
        {
            get { return descuento; }
        }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            AsignarDescuento();
        }

        public abstract void AsignarDescuento();

        public static bool operator ==(Persona dniPersona, List<Persona> listaPersonas)
        {
            foreach (Persona persona in listaPersonas)
            {
                if (persona.dni == dniPersona.dni)
                    return true;
            }
            return false;
        }
    
        public static bool operator !=(Persona dniPersona, List<Persona> listaPersonas)
        {
            return (!(dniPersona == listaPersonas));
        }

       

        
    }
}
