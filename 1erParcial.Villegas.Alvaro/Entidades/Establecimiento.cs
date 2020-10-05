using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Establecimiento
    {
        static string nombreEstablecimiento;
        static List<Persona> clientes;
        static List<Empleado> empleados;
        static List<Producto> productos;
        static List<Compra> compras;
        static Empleado usuarioActivo;
        static Dictionary<string, string> userPassword;
        static int numeroVenta;


        public static List<Producto> Productos
        {
            get { return productos; }
        }
        public static List<Empleado> Empleados
        {
            get { return empleados; }
        }

        public static string NombreEstablecimiento
        {
            get { return nombreEstablecimiento; }
        }

        public static Empleado UsuarioActivo
        {
            get { return usuarioActivo; }

            set
            {

                if (VerificarUsuario((Empleado)value))
                {
                    usuarioActivo = value;
                }

            }
        }

        public static Dictionary<string, string> UserPassword
        {
            get { return userPassword; }
        }


        static Establecimiento()
        {
            nombreEstablecimiento = "KwiK E Mart";
            clientes = new List<Persona>();
            empleados = new List<Empleado>();
            productos = new List<Producto>();
            compras = new List<Compra>();
            userPassword = new Dictionary<string, string>();
        }
        /// <summary>
        /// Busca el Ultimo numero de Venta y lo Asgina para ser usado en la proxima compra
        /// </summary>
        private static void setNumeroVenta()
        {
            if (compras.Count == 0)
                numeroVenta = 0;
            else
                numeroVenta = compras[compras.Count - 1].NumeroCompra;
        }

        public static List<Compra> Compras
        {
            get
            {
                { return compras; }
            }
        }

        public static List<Persona> Clientes
        {
            get
            {
                return clientes;
            }
        }
        

        public static int NumeroVenta
        {

            get
            {
                setNumeroVenta();
                if(numeroVenta == 0)
                {

                    return 0;
                }
                return numeroVenta;
            }
        }
        /// <summary>
        /// Agrega un Elemento a la Lista de Clientes
        /// </summary>
        /// <param name="personaAñadir"> persona para Agregar</param>
        public static void AgregarPersona(Persona personaAñadir)
        {
            clientes.Add((Cliente)personaAñadir);
        }
        /// <summary>
        /// Agrega un Elemento en la Lista de Productos
        /// </summary>
        /// <param name="productoAñadir"> Producto para Agregar</param>
        public static void AgregarProducto(Producto productoAñadir)
        {
            productos.Add(productoAñadir);
        }

        
        /// <summary>
        /// Agrega una Compra a la Lista de Compras
        /// </summary>
        /// <param name="compraAñadir"></param>
        public static void AgregarCompra(Compra compraAñadir)
        {
            compras.Add(compraAñadir);
        }

        public static string GetNombre()
        {
            return nombreEstablecimiento;
        }
        /// <summary>
        /// Retorna la Lista de Clientes
        /// </summary>
        /// <returns></returns>
        public static List<Persona> GetPersonas()
        {
            return clientes;
        }
        /// <summary>
        /// Retorna la lista de productos
        /// </summary>
        /// <returns></returns>
        public static List<Producto> GetProductos()
        {
            return productos;
        }
        /// <summary>
        /// retorna un Producto según el indice en la Lista
        /// </summary>
        /// <param name="index" indice del producto en la lista></param>
        /// <returns></returns>
        public static Producto GetProducto(int index)
        {
            return productos[index];
        }
        /// <summary>
        /// Retorna lista de Compras
        /// </summary>
        /// <returns></returns>
        public static List<Compra> GetCompras()
        {
            return compras;

        }
        /// <summary>
        /// Verifica que el Usuario  se encuentra en la Lista de Empleados
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        static bool VerificarUsuario(Empleado usuario)
        {
            if (Establecimiento.empleados.Contains(usuario))
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Retorna un producto segun su Codigo de Prodcuto
        /// </summary>
        /// <param name="codigoProducto"></param>
        /// <returns></returns>
        public static Producto GetProductoById(int codigoProducto)
        {
            foreach (Producto producto in productos)
            {
                if (producto.IdProducto == codigoProducto)
                    return producto;
            }
            return null;
        }
        /// <summary>
        /// Retorna una Persona según su codigo de Persona
        /// </summary>
        /// <param name="codigoPersona"></param>
        /// <returns></returns>
        public static Persona GetPersonaById(int codigoPersona)
        {
            foreach (Persona persona in clientes)
            {
                if (persona.Dni == codigoPersona)
                    return persona;
            }
            return null;
        }
        /// <summary>
        /// Remueve Stock de un producto.
        /// </summary>
        /// <param name="listaProductosVendidos"></param>
        public static void RemoverStock(List<Producto> listaProductosVendidos)
        {
            foreach (Producto productoVendido in listaProductosVendidos)
            {
                Producto.RemoverCantidad(productoVendido);

            }




        }


    }

}

