using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int idProducto;
        string nombreProducto;
        float precioProducto;
        int stockProducto;
        string pathImagen;

        public int IdProducto
        {
            get { return this.idProducto; }
        }
        public string NombreProducto
        {
            get { return this.nombreProducto; }
        }
        public float PrecioProducto
        {
            get { return this.precioProducto; }
        }
        public int StockProducto
        {
            get { return this.stockProducto; }
        }
        public string PathImagen
        {
            get { return this.pathImagen; }
        }
        private void SumaStock(int cantidad)
        {
            this.stockProducto = cantidad;
        }

        public Producto(int idProducto, string nombreProducto, float precioProducto, int stockProducto, string pathImagen)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            this.pathImagen = pathImagen;

        }

        public static bool operator ==(List<Producto> listaProductos, Producto productoAComparar)
        {
            foreach (Producto productos in listaProductos)
            {
                if (productos.nombreProducto == productoAComparar.nombreProducto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(List<Producto> listaProductos, Producto productoAComparar)
        {
            return (!(listaProductos == productoAComparar));
        }

        public static bool operator ==(Producto productoEnLista, Producto productoAComparar)
        {
            if ( productoEnLista.idProducto == productoAComparar.idProducto)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto productoEnLista, Producto productoAComparar)
        {
                

                return (!(productoEnLista.idProducto == productoAComparar.idProducto));
            
        }

        public static bool operator +(List<Producto> listaProductos, Producto productoParaAgregar)
        {
            if (listaProductos.Count > 0 && SeEncuentraEnLista(listaProductos, productoParaAgregar))
            {
                foreach (Producto productoEnLista in listaProductos)
                {
                    if (productoParaAgregar == productoEnLista && productoEnLista.StockProducto < Establecimiento.GetProductoById(productoParaAgregar.idProducto).stockProducto)
                    {
                        productoEnLista.SumaStock(productoEnLista.StockProducto+ 1);
                        return true;
                    }
                }
            }
            else
            {
                listaProductos.Add(productoParaAgregar);
                return true;
            }
            return false;
        }

        private static bool SeEncuentraEnLista(List<Producto> listaProductos, Producto productoABuscar)
        {
            foreach (Producto producto in listaProductos)
            {
                if (producto.idProducto == productoABuscar.idProducto)
                    return true;
            }
            return false;
        }

        public static int AgregarCantidad(List<Producto> listaProductos, Producto productoParaAgregar, int cantidad)
        {
            if (listaProductos.Count > 0 && SeEncuentraEnLista(listaProductos, productoParaAgregar))
            {
                foreach (Producto productoEnLista in listaProductos)
                {
                    if (productoParaAgregar == productoEnLista)
                    {
                        if (cantidad <= Establecimiento.GetProductoById(productoParaAgregar.idProducto).stockProducto)
                        {
                            productoEnLista.SumaStock(cantidad);
                            return 1;
                        }
                        else if (cantidad > Establecimiento.GetProductoById(productoParaAgregar.idProducto).stockProducto)
                        {
                            productoEnLista.SumaStock(Establecimiento.GetProductoById(productoParaAgregar.idProducto).stockProducto);
                            return 0;
                        }
                    }
                }
            }
            return -1;
        }

        public static void RemoverCantidad(Producto productoVendido)
        {
            foreach (Producto productoEnLista in Establecimiento.Productos)
            {
                if (productoVendido.IdProducto == productoEnLista.IdProducto)
                {
                    productoEnLista.SumaStock(productoEnLista.stockProducto - productoVendido.stockProducto);
                }
            }
        }
        

        public static Producto GetProductoById(int codigoProducto, List<Producto> listaProductos)
        {
            foreach (Producto producto in listaProductos)
            {
                if (producto.idProducto == codigoProducto)
                    return producto;
            }
            return null;
        }

        public static bool operator +(Producto productoParaAgregar, int n)
        {
            Establecimiento.AgregarProducto(productoParaAgregar);
            return true;
        }


        public static int operator >=(Producto productoEnLista, Producto productoAComparar)
        {
            int retorno = 0;
            if (productoEnLista.stockProducto > productoAComparar.stockProducto)
            {
                return 1;
            }
            else if (productoEnLista.stockProducto < productoAComparar.stockProducto)
            {
                return -1;
            }
            return retorno;
        }
        public static int operator <=(Producto productoEnLista, Producto productoAComparar)
        {

            if (productoEnLista >= productoAComparar == 1)
                return -1;
            else if (productoEnLista >= productoAComparar == -1)
                return 1;

            return 0;
        }

        public override string ToString()
        {
            return $"{this.idProducto,10}  {this.nombreProducto,25}            { this.stockProducto,10}   {this.precioProducto,15}";
        }
        


}
}
