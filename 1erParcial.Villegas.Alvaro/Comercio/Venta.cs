using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Comercio
{
    public partial class Venta : Form
    {

        float totalFinal = 0;
        List<Producto> productosVenta;
        Persona clienteFinal;
        float subTotal = 0;
        float descuento = 0;
        SoundPlayer sonidoVenta = new SoundPlayer(@"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Sonido\cash2.wav");


        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            lb_vendedor.Text = Establecimiento.UsuarioActivo.ToString();
            subTotal = 0;
            totalFinal = 0;
            LimpiarCodigo();
            productosVenta = new List<Producto>();
            clienteFinal = new Cliente();
            this.dgv_ListaInventario.DataSource = null;
            this.dgv_ListaInventario.DataSource = Establecimiento.Productos;

            this.dgv_ListaInventario.Columns[0].Width = 75;
            this.dgv_ListaInventario.Columns[1].Width = 150;
            this.dgv_ListaInventario.Columns[2].Width = 100;
            this.dgv_ListaInventario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_ListaInventario.Columns[3].Width = 100;
            this.dgv_ListaInventario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_ListaInventario.Columns[4].Visible = false;

            dgv_ListaVenta.Rows.Clear();


            lb_Subtotal.Text = "0";
            lb_descuento.Text = "0";
            lb_totalFinal.Text = "0";
        }



        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            Producto auxProducto;

            int codigoProducto = (int)e.Data.GetData(typeof(int));
            auxProducto = Establecimiento.GetProductoById(codigoProducto);
            if (auxProducto.StockProducto > 0)
            {
                auxProducto = new Producto(auxProducto.IdProducto, auxProducto.NombreProducto, auxProducto.PrecioProducto, 1, auxProducto.PathImagen);
                if (productosVenta + auxProducto)
                {
                    this.dgvDibujar(productosVenta);
                }
            }
        }

        private void dgvDibujar(List<Producto> lista)
        {
            dgv_ListaVenta.Rows.Clear();
            foreach (Producto item in lista)
            {
                this.dgv_ListaVenta.Rows.Add(item.IdProducto, item.NombreProducto, item.PrecioProducto.ToString("n2"), item.StockProducto);

            }
            CalcularSubtotal();
            lb_Subtotal.Text = subTotal.ToString("n2");
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            IngresaCantidad frmIngresaCantidad = new IngresaCantidad();
            if (dgv_ListaVenta.Rows.Count > 0 && dgv_ListaVenta.CurrentCell.RowIndex > -1)
            {
                if (dgv_ListaVenta.CurrentCell.ColumnIndex == 3)
                {
                    ModificarCantidad();
                }
                else if (dgv_ListaVenta.CurrentCell.ColumnIndex == 4)
                {
                    RemoverProducto();
                }
            }
            this.dgvDibujar(productosVenta);
        }

        private void ModificarCantidad()
        {
            int cantidad;
            IngresaCantidad frmIngresaCantidad = new IngresaCantidad();
            frmIngresaCantidad.ShowDialog();
            cantidad = frmIngresaCantidad.cantidad;
            if (cantidad > 0)
                Producto.AgregarCantidad(productosVenta, productosVenta[dgv_ListaVenta.CurrentRow.Index], cantidad);
        }

        private void RemoverProducto()
        {
            productosVenta.Remove(productosVenta[dgv_ListaVenta.CurrentRow.Index]);
        }

        private void dgv_ListaInventario_MouseDown(object sender, MouseEventArgs e)
        {
            this.dgv_ListaInventario.DoDragDrop(dgv_ListaInventario.CurrentRow.Cells[0].Value, DragDropEffects.Copy);
        }


        public void CalcularSubtotal()
        {
            this.subTotal = 0;
            foreach (Producto productoEnLista in productosVenta)
            {
                this.subTotal += productoEnLista.PrecioProducto * productoEnLista.StockProducto;
            }
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            totalFinal = subTotal;
            if (subTotal > 0 && clienteFinal.Dni > 0)
            {
                clienteFinal.AsignarDescuento();
                totalFinal -= clienteFinal.Descuento * subTotal / 100;
                lb_descuento.Text = clienteFinal.Descuento.ToString() + "%";
                descuento = clienteFinal.Descuento;
            }
            else
            {
                totalFinal = subTotal;
            }
            lb_totalFinal.Text = totalFinal.ToString("n2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra nuevaCompra;
            if (!(string.IsNullOrEmpty(txbx_dniCliente.Text)) && productosVenta.Count > 0)
            {
                clienteFinal = new Cliente(txbx_nombreCliente.Text, txbx_apellidoCliente.Text, int.Parse(txbx_dniCliente.Text));
                nuevaCompra = new Compra(Establecimiento.UsuarioActivo, (Persona)clienteFinal, productosVenta, subTotal, descuento, totalFinal, DateTime.Now.ToString(), Establecimiento.NumeroVenta + 1);
                Establecimiento.AgregarCompra(nuevaCompra);
                if (clienteFinal != Establecimiento.Clientes)
                {
                    Establecimiento.Clientes.Add(clienteFinal);
                }
                Establecimiento.RemoverStock(nuevaCompra.ProductosVenta);
                nuevaCompra.CrearTicket();
                sonidoVenta.Play();
                MessageBox.Show("“Gracias!! Vuelva prontosss”");
                Venta_Load(sender, e);
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(txbx_dniCliente.Text, out aux) && Validaciones.DniPersonaEnLista(aux))
            {
                clienteFinal = (Persona)Establecimiento.GetPersonaById(aux);
                MostrarCliente();
                txbx_nombreCliente.Enabled = false;
                txbx_apellidoCliente.Enabled = false;

            }
            else
            {
                LimpiarTextos();
            }
            this.dgvDibujar(productosVenta);
        }

        private void LimpiarCodigo()
        {
            LimpiarTextos();
            txbx_dniCliente.Text = "";
        }
        private void LimpiarTextos()
        {
            txbx_nombreCliente.Text = null;
            txbx_apellidoCliente.Text = null;
            txbx_nombreCliente.Enabled = true;
            txbx_apellidoCliente.Enabled = true;
            lb_descuento.Text = "";
        }

        private void MostrarCliente()
        {
            txbx_nombreCliente.Text = clienteFinal.Nombre;
            txbx_apellidoCliente.Text = clienteFinal.Apellido;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int aux;
            if (!(string.IsNullOrEmpty(txbx_dniCliente.Text.ToString())))
                if (!(int.TryParse(txbx_dniCliente.Text, out aux)))
                {
                    txbx_dniCliente.Text = "";
                    MessageBox.Show("Dni Inválido");

                }
        }

        private void bt_salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
