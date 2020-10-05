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

namespace Comercio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Stock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            this.Hide();
            stock.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = Establecimiento.NombreEstablecimiento;
            pb_Logo.Image = Image.FromFile(@"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\logo.png");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            this.Hide();
            venta.ShowDialog();
            this.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_reportes_Click(object sender, EventArgs e)
        {
            FrmReporte reportes = new FrmReporte();
            this.Hide();
            reportes.ShowDialog();
            this.Show();
        }
    }
}
