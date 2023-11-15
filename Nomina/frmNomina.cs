using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nomina.Biblioteca;

namespace Nomina
{
    public partial class frmNomina : Form
    {
        ListViewItem item;
        List<Empleado> empleados = new List<Empleado>();
        IR impuestoRentaCalculator = new IR();
        CalculadorFinanciero Calculo = new CalculadorFinanciero();
        INSS iNSS = new INSS();

        public frmNomina()
        {
            InitializeComponent();
            frmLogin frm = new frmLogin();
            frm.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtCargo.Text) ||
        string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, llene todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string cargo = txtCargo.Text;
                double Bono = Convert.ToDouble(txtBono.Text);
                double salario = Convert.ToDouble(txtSalario.Text);
                double viatico = Convert.ToDouble(txtViatico.Text);
                double depreciacion = Convert.ToDouble(txtDep.Text);
                double horasE = Convert.ToDouble(txtHorasE.Text);
                double total = (salario + Bono + viatico + depreciacion + horasE);

                Empleado nuevoEmpleado = new Empleado(Nombre, Apellido, total);
                double impuestoRenta = impuestoRentaCalculator.CalcularImpuestoRenta(nuevoEmpleado.Salario);
                double INSS = iNSS.CalcularINSS(nuevoEmpleado.Salario);
                double INSSPatronal = Calculo.CalcularINSSPatronal(nuevoEmpleado.Salario);
                double Vacaciones = Calculo.CalcularVacaciones(nuevoEmpleado.Salario);
                double Treceavo = Calculo.CalcularTreceavo(nuevoEmpleado.Salario);
                double Indemnizacion = Calculo.CalcularIndemnizacion(nuevoEmpleado.Salario);
                double Inatec = Calculo.CalcularINATEC(nuevoEmpleado.Salario);
                ListViewItem fila = new ListViewItem(cargo);
                ListViewItem fila2 = new ListViewItem(total.ToString("C"));

                fila.SubItems.Add($"{Nombre} {Apellido}");
                fila.SubItems.Add(salario.ToString("C"));
                fila.SubItems.Add(depreciacion.ToString("C"));
                fila.SubItems.Add(viatico.ToString("C"));
                fila.SubItems.Add(horasE.ToString("C"));
                fila.SubItems.Add(Bono.ToString("C"));
                fila.SubItems.Add(total.ToString("C"));
                fila.SubItems.Add(INSS.ToString("C"));
                fila.SubItems.Add(impuestoRenta.ToString("C"));
                fila.SubItems.Add(Neto(nuevoEmpleado.Salario, INSS, impuestoRenta).ToString("C"));

                lsvEmpleado.Items.Add(fila);

                fila2.SubItems.Add(INSSPatronal.ToString("C"));
                fila2.SubItems.Add(Vacaciones.ToString("C"));
                fila2.SubItems.Add(Treceavo.ToString("C"));
                fila2.SubItems.Add(Indemnizacion.ToString("C"));
                fila2.SubItems.Add(Inatec.ToString("C"));
                fila2.SubItems.Add(Neto2(INSSPatronal, Vacaciones, Treceavo
                    , Indemnizacion, Inatec).ToString("C"));

                lsvEmpleador.Items.Add(fila2);

                clear();
            }
        }
        private double Neto(double a, double b, double c)
        {
            return (a - b - c);
        }
        private double Neto2(double a, double b, double c, double d, double e)
        {
            return (a + b + c + d + e);
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void clear()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            txtBono.Clear();
            txtDep.Clear();
            txtHorasE.Clear();
            txtViatico.Clear();
            mtxtCedula.Clear();

            txtBono.Text = "0";
            txtDep.Text = "0";
            txtHorasE.Text = "0";
            txtViatico.Text = "0";

            txtNombre.Focus();
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos, tecla de retroceso y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            // Valida si el valor es mayor que cero al perder el foco
            if (double.TryParse(txtSalario.Text, out double salario) && salario <= 0)
            {
                MessageBox.Show("El salario debe ser mayor que cero.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalario.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras de la A a la Z (mayúsculas y minúsculas), la tecla de retroceso y el espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;

                // Muestra un mensaje de advertencia
                MessageBox.Show("Por favor, ingrese solo letras (A-Z).", "Caracteres no permitidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
