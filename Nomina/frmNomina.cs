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
    public partial class frmNomina : Form
    {
        ListViewItem item;
        List<Empleado> empleados = new List<Empleado>();
        public frmNomina()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            ListViewItem fila = new ListViewItem(cargo);
            ListViewItem fila2 = new ListViewItem(total.ToString("C"));

            fila.SubItems.Add($"{Nombre} {Apellido}");
            fila.SubItems.Add(salario.ToString("C"));
            fila.SubItems.Add(depreciacion.ToString("C"));
            fila.SubItems.Add(viatico.ToString("C"));
            fila.SubItems.Add(horasE.ToString("C"));
            fila.SubItems.Add(Bono.ToString("C"));
            fila.SubItems.Add(total.ToString("C"));
            fila.SubItems.Add(CalcularINSS(nuevoEmpleado.Salario).ToString("C"));
            fila.SubItems.Add(CalcularImpuestoRenta(nuevoEmpleado.Salario).ToString("C"));
            fila.SubItems.Add(Neto(nuevoEmpleado.Salario, CalcularINSS(nuevoEmpleado.Salario), CalcularImpuestoRenta(nuevoEmpleado.Salario)).ToString("C"));

            lsvEmpleado.Items.Add(fila);

            fila2.SubItems.Add(CalcularINSSPatronal(nuevoEmpleado.Salario).ToString("C"));
            fila2.SubItems.Add(Vacaciones(nuevoEmpleado.Salario).ToString("C"));
            fila2.SubItems.Add(treceavo(nuevoEmpleado.Salario).ToString("C"));
            fila2.SubItems.Add(Indemnizacion(nuevoEmpleado.Salario).ToString("C"));
            fila2.SubItems.Add(INATEC(nuevoEmpleado.Salario).ToString("C"));
            fila2.SubItems.Add(Neto2(CalcularINSSPatronal(nuevoEmpleado.Salario), Vacaciones(nuevoEmpleado.Salario), treceavo(nuevoEmpleado.Salario)
                , Indemnizacion(nuevoEmpleado.Salario), INATEC(nuevoEmpleado.Salario)).ToString("C"));

            lsvEmpleador.Items.Add(fila2);

            clear();
        }

        private double CalcularImpuestoRenta(double salario)
        {
            double s = salario * 12;

            if (s <= 100000.00)
            {
                return 0;
            }
            else if (s > 100000.00 && s <= 200000.00)
            {
                return ((s - 100000) * 0.15) / 12;
            }
            else if (s > 200000.00 && s <= 350000.00)
            {
                return (((s - 200000) * 0.20) + 15000) / 12;
            }
            else if (s > 350000.00 && s <= 500000.00)
            {
                return (((s - 350000) * 0.25) + 45000) / 12;
            }
            else
            {
                return (((s - 500000) * 0.30) + 87500) / 12;
            }

        }
        private double CalcularINSS(double salario)
        {
            return (salario * 0.07);
        }

        private double Neto(double a, double b, double c)
        {
            return (a - b - c);
        }
        private double CalcularINSSPatronal(double salario)
        {
            return (salario * 0.225);
        }
        private double Vacaciones(double salario)
        {
            return (salario * 0.0833);
        }
        private double treceavo(double salario)
        {
            return (salario * 0.0833);
        }
        private double Indemnizacion(double salario)
        {
            return (salario * 0.0833);
        }
        private double INATEC(double salario)
        {
            return (salario * 0.02);
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

    }
}
