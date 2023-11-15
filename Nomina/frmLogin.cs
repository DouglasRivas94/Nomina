using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina
{
    public partial class frmLogin : Form
    {
        static string usuario = "azazel";
        static string contraseña = "s0phy.23";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar si el nombre de usuario y la contraseña coinciden con los almacenados
            if (txtUsuario.Text == usuario && txtPass.Text == contraseña)
            {
                frmNomina frmNomina = new frmNomina();
                frmNomina.Show();

                clean();

            }
            else
            {
                // Si no coinciden, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clean()
        {
            txtUsuario.Clear();
            txtPass.Clear();
        }
    }
}
