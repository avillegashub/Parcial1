using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Comercio
{
    public partial class FrmReporte : Form
    {
        List<Compra> listaCompraEmpleado;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void txbx_DniEmpleado_TextChanged(object sender, EventArgs e)
        {

            int aux;
            int flag = -1;
            cbox_Ventas.Items.Clear();
            foreach (Empleado empleado in Establecimiento.Empleados)
            {
                if (int.TryParse(txbx_DniEmpleado.Text, out aux) && empleado.Dni == aux)
                {
                    flag = 0;
                    CargaVentas(empleado);
                    txbx_apellidoEmpleado.Text = empleado.Apellido;
                    txbx_nombreEmpleado.Text = empleado.Nombre;
                    
                }
            }
            if (flag == -1)
            {
                CleanTextos();
               
            }
        }

        private void CleanTextos()
        {
            txbx_apellidoEmpleado.Text = "";
            txbx_nombreEmpleado.Text = "";
            txbx_descuento.Text = "";
            txbx_dniCliente.Text = "";
            txbx_fechaYHora.Text = "";
            txbx_total.Text = "";
            txbx_subTotal.Text = "";
            txbx_nombreCliente.Text = "";
            txbx_apellidoCliente.Text = "";
            cbox_Ventas.Text = "";
            dgv_listaProductos.Rows.Clear();
        }

        private void CargaVentas(Empleado empleado)
        {
            foreach (Compra compra in Establecimiento.Compras)
            {

                if(compra.Vendedor == empleado)
                    listaCompraEmpleado.Add(compra);
                cbox_Ventas.Items.Add(compra.NumeroCompra);
            }
        }

        private void cbox_Ventas_TextChanged(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(cbox_Ventas.Text)))
            {
                foreach (Compra compra in listaCompraEmpleado)
                {
                    if (compra.NumeroCompra == int.Parse(cbox_Ventas.Text))
                    {
                        LoadData(compra);
                         break;
                    }
                }
            }
        }

        private void LoadData(Compra compra)
        {
            dgvDibujar(compra.ProductosVenta);
            txbx_apellidoCliente.Text = compra.Cliente.Apellido;
            txbx_dniCliente.Text = compra.Cliente.Dni.ToString();
            txbx_nombreCliente.Text = compra.Cliente.Nombre;
            txbx_subTotal.Text = compra.SubTotal.ToString("n2");
            txbx_total.Text = compra.TotalFinal.ToString("n2");
            txbx_descuento.Text = compra.Descuento.ToString()+"%";
            txbx_fechaYHora.Text = compra.FechaHora.ToString();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            listaCompraEmpleado = new List<Compra>();
        }

        private void dgvDibujar(List<Producto> lista)
        {
            dgv_listaProductos.Rows.Clear();
            foreach (Producto item in lista)
            {
                this.dgv_listaProductos.Rows.Add(item.IdProducto, item.NombreProducto, item.PrecioProducto.ToString("n2"), item.StockProducto);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

