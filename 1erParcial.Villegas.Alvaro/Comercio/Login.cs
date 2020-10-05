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
    public partial class Login : Form
    {

        public int user;
        public Login()
        {
            InitializeComponent();
           
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
                
            string passwordAux;
            if (Establecimiento.UserPassword.ContainsKey(txbx_Usuario.Text) && Establecimiento.UserPassword.TryGetValue(txbx_Usuario.Text, out passwordAux) && passwordAux == txbx_password.Text)
            {
                Establecimiento.UsuarioActivo = (Empleado)Establecimiento.GetPersonaById(int.Parse(txbx_Usuario.Text));
                
                Menu menu = new Menu();
                timer1.Enabled = false;
                this.Hide();

                menu.ShowDialog();
                this.Show();
                timer1.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Usuario o Clave inválidos");
                txbx_Usuario.Text = null;
                txbx_password.Text = null;
            }
                ResetTextBoxes();

        }


        private void Login_Load(object sender, EventArgs e)
        {
           

            

            pb_Logo.Image = Image.FromFile(@"C:\Users\Bitter\Desktop\1erParcial.Villegas.Alvaro\Comercio\Resources\Imagenes\logo.png");
            
            this.Text = Establecimiento.NombreEstablecimiento;
            HardCode.HardCodeLogin();
            HardCode.HardCodeProductos();
            HardCode.HardCodeClientes();
            HardCode.HardCodeCompras();

        }

        private void ResetTextBoxes()
        {
            txbx_Usuario.Text = null;
            txbx_password.Text = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
