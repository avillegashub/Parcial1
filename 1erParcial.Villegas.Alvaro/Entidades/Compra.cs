using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        Empleado vendedor;
        Persona cliente;
        List<Producto> productosVenta;
        string fechaHora;
        int numeroCompra;
        float subTotal;
        float descuento;
        float totalFinal;



        public Empleado Vendedor { get => vendedor; }
        public Persona Cliente { get => cliente; }
        public List<Producto> ProductosVenta { get => productosVenta; }
        public string FechaHora { get => fechaHora; }
        public int NumeroCompra { get => numeroCompra; }
        public float SubTotal { get => subTotal; }
        public float Descuento { get => descuento; }
        public float TotalFinal { get => totalFinal; }

      
        public Compra(Empleado vendedor, Persona cliente, List<Producto> productosVenta, float subTotal, float descuento, float total, string fechaHora, int numeroCompra)
        {
            this.vendedor = vendedor;
            this.cliente = cliente;
            this.productosVenta = productosVenta;
            this.subTotal = subTotal;
            this.totalFinal = total;
            this.descuento = descuento;
            this.fechaHora = fechaHora;
            this.numeroCompra = numeroCompra;

        }
        public Compra(Persona cliente, List<Producto> productosVenta, float subTotal, float descuento, float total, string fechaHora, int numeroCompra)
        {
            this.vendedor = (Empleado)Establecimiento.UsuarioActivo;
            this.cliente = cliente;
            this.productosVenta = productosVenta;
            this.subTotal = subTotal;
            this.totalFinal = total;
            this.descuento = descuento;
            this.fechaHora = fechaHora;
            this.numeroCompra = numeroCompra;

        }

       /// <summary>
       /// Crea el Ticket de la compra
       /// </summary>
        public void CrearTicket()
        {
            using (StreamWriter sw = new StreamWriter($@"C:\Test\{NumeroCompra}.txt"))
            {

                sw.WriteLine($"==========================={Establecimiento.NombreEstablecimiento}==============");
                sw.WriteLine(" ");
                sw.WriteLine($"Cliente : {Cliente.ToString()}");
                sw.WriteLine(" ");
                sw.WriteLine($"Cajero : {Vendedor.ToString()}");
                sw.WriteLine(" ");
                sw.WriteLine($"{FechaHora}");
                sw.WriteLine(" ");
                sw.WriteLine($"  Codigo                 Nombre                  Cantidad               Precio");
                sw.WriteLine(" ");

                foreach (Producto producto in ProductosVenta)
                {
                    sw.WriteLine($"{producto.ToString()}");
                }
                sw.WriteLine(" ");

                sw.WriteLine($"                                                       Subtotal:  {SubTotal,10}");
                sw.WriteLine($"                                                      Descuento:  {Descuento,10}");
                sw.WriteLine($"                                                          Total:  {TotalFinal,10}");

                sw.WriteLine(" ");

                sw.WriteLine($"==============Yohoo!==============");

            }
        }

    }

   
}
