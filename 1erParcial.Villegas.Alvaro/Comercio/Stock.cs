using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Comercio
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            txbx_codigo.Text = 0.ToString();
            this.Text = Establecimiento.NombreEstablecimiento;
            dgv_ListaProductos.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_ListaProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            limpiarGridStock();
            dgvDibujar(Establecimiento.Productos);
        }

        private void dgvDibujar(List<Producto> listaProductos)
        {
            Image img;
            foreach (Producto item in listaProductos)
            {
                img = Image.FromFile(item.PathImagen);
                dgv_ListaProductos.Rows.Add(img, item.IdProducto, item.NombreProducto, item.PrecioProducto, item.StockProducto);
            }
        }


        private void MostrarProducto(Producto producto)
        {
            Image img = Image.FromFile(producto.PathImagen);
            txbxPrecio.Text = producto.PrecioProducto.ToString("n2");
            txbx_stock.Text = producto.StockProducto.ToString();
            txbx_nombre.Text = producto.NombreProducto;
            textBox1.Text = producto.PathImagen;
            pcbx_imagenProducto.Image = img;
        }

        private void MostrarConCodigo(Producto producto)
        {
            txbx_codigo.Text = producto.IdProducto.ToString();
            MostrarProducto(producto);

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = (int)dgv_ListaProductos.CurrentRow.Cells["dgv_columnaId"].Value;

            MostrarConCodigo(Establecimiento.GetProductoById(index));


        }

        private void txbx_codigo_TextChanged(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(txbx_codigo.Text, out aux) && Validaciones.CodigoEnLista(aux))
            {
                MostrarProducto(Establecimiento.GetProductoById(aux));
            }
            else
            {
                LimpiarTextos();
            }
        }

        private void LimpiarTextos()
        {
            LimpiarPrecio();
            txbx_nombre.Text = "";
            txbx_stock.Text = "";
            textBox1.Text = "";
            pcbx_imagenProducto.Image = null;
            pcbx_imagenProducto.Refresh();

        }
        private void LimpiarCodigo()
        {
            txbx_codigo.Text = "";
        }

        private void LimpiarPrecio()
        {
            txbxPrecio.Text = "";
        }




        private void bt_anadir_Click(object sender, EventArgs e)
        {
            int auxStock;
            int cantidadAgregar = 0;
            int flag = -1;
            Producto auxiliar;

            if (!(string.IsNullOrEmpty(txbx_nombre.Text)) && !(string.IsNullOrEmpty(txbx_codigo.Text)) && !(string.IsNullOrEmpty(txbxPrecio.Text)))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = @"C:\Users\Bitter\source\repos\1erParcial.Villegas.Alvaro\Imagenes\noimage.png";
                }
                if (!(int.TryParse(cbox_Agregar.Text, out cantidadAgregar)))
                {
                    cantidadAgregar = 0;
                }
                if (!(int.TryParse(txbx_stock.Text, out auxStock)))
                {
                    auxStock = 0;
                }
                auxiliar = new Producto(int.Parse(txbx_codigo.Text), txbx_nombre.Text, float.Parse(txbxPrecio.Text), auxStock + cantidadAgregar, textBox1.Text);
                for (int i = 0; i < Establecimiento.Productos.Count; i++)
                {
                    if (auxiliar.IdProducto == Establecimiento.Productos[i].IdProducto && auxiliar.NombreProducto == Establecimiento.Productos[i].NombreProducto)
                    {
                        flag = 0;
                        Establecimiento.Productos.Remove(Establecimiento.Productos[i]);
                        Establecimiento.Productos.Insert(i, auxiliar);
                        MessageBox.Show("Cantidad Agregada");
                        break;

                    }
                    else if (auxiliar.IdProducto == Establecimiento.Productos[i].IdProducto && auxiliar.NombreProducto != Establecimiento.Productos[i].NombreProducto)
                    {
                        flag = 0;
                        MessageBox.Show("No se puede cambiar el Nombre");
                        break;
                    }
                }
                if (flag == -1)
                {
                    if (!(Validaciones.NombreEnLista(auxiliar.NombreProducto)))
                    {
                        Establecimiento.Productos.Add(auxiliar);
                        MessageBox.Show("Producto ingresado");
                    }
                    else
                    {
                        MessageBox.Show("Error!\n\n Otro articulo contiene el mismo nombre");
                    }
                }

                MostrarConCodigo(auxiliar);
                limpiarGridStock();
                dgvDibujar(Establecimiento.Productos);
            }
        }



        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            int auxFiltro;
            List<Producto> productosFiltro;
            if (!(string.IsNullOrEmpty(cbox_Filtrar.Text)) && Establecimiento.Productos != null && Establecimiento.Productos.Count > 0 && int.TryParse(cbox_Filtrar.Text, out auxFiltro))
            {
            productosFiltro = new List<Producto>();

                foreach (Producto item in Establecimiento.Productos)
                {
                    if (item.StockProducto <= auxFiltro)
                    {
                        productosFiltro.Add(item);
                    }
                }
                limpiarGridStock();
                dgvDibujar(productosFiltro);
            }

        }

        private void limpiarGridStock()
        {
            dgv_ListaProductos.Rows.Clear();
            dgv_ListaProductos.Refresh();
            dgv_ListaProductos.Update();
        }

        private void txbx_codigo_Leave(object sender, EventArgs e)
        {
            int aux;
            if (!(int.TryParse(txbx_codigo.Text, out aux)))
            {
                MessageBox.Show("Codigo Inválido");
                LimpiarCodigo();
            }
        }

        private void txbxPrecio_Leave(object sender, EventArgs e)
        {
            float aux;
            if (!(float.TryParse(txbxPrecio.Text, out aux)))
            {
                MessageBox.Show("Precio Inválido");
                LimpiarPrecio();
            }
        }

        private void bt_clean_Click(object sender, EventArgs e)
        {
            limpiarGridStock();
            pcbx_imagenProducto.Image = null;
            pcbx_imagenProducto.Refresh();
            dgvDibujar(Establecimiento.Productos);
            LimpiarCodigo();
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            int aux;
            if (!(int.TryParse(cbox_Agregar.Text, out aux)))
            {
                MessageBox.Show("Ingrese un numero");
                cbox_Agregar.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }




}
