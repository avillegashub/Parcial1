using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empleado : Persona
    {
        protected int user;
        protected string password;
        protected bool admin;


        public Empleado(string nombre, string apellido, int dni, string password) : base(nombre, apellido, dni)
        {
            this.user = dni;
            this.password = password;
        }

        public int User
        {
            get
            {
                return this.user;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
        }
        public bool Admin
        {
            get { return this.admin; }
        }

        public abstract void PermisoAdmin();

        public override string ToString()
        {
            return $"{this.nombre} {this.apellido} CajeroNum: {this.dni}";
        }


    }
}
