using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Biblioteca
{
    internal class CalculadorFinanciero
    {
        public double CalcularINSSPatronal(double salario)
        {
            return salario * 0.225;
        }

        public double CalcularVacaciones(double salario)
        {
            return salario * 0.0833;
        }

        public double CalcularTreceavo(double salario)
        {
            return salario * 0.0833;
        }

        public double CalcularIndemnizacion(double salario)
        {
            return salario * 0.0833;
        }

        public double CalcularINATEC(double salario)
        {
            return salario * 0.02;
        }
    }
}
