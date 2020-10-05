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
    public partial class IngresaCantidad : Form
    {
        public int cantidad;
        public IngresaCantidad()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

                cantidad = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(int.TryParse(txbx_cantidad.Text, out cantidad)))
            {
                cantidad = 1;
            }
            
            this.Close();

        }
    }
}
