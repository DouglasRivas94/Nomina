using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Biblioteca
{
    internal class IR
    {
        public double CalcularImpuestoRentaAnual(double salarioAnual)
        {
            if (salarioAnual <= 100000.00)
            {
                return 0;
            }
            else if (salarioAnual > 100000.00 && salarioAnual <= 200000.00)
            {
                return ((salarioAnual - 100000) * 0.15) / 12;
            }
            else if (salarioAnual > 200000.00 && salarioAnual <= 350000.00)
            {
                return (((salarioAnual - 200000) * 0.20) + 15000) / 12;
            }
            else if (salarioAnual > 350000.00 && salarioAnual <= 500000.00)
            {
                return (((salarioAnual - 350000) * 0.25) + 45000) / 12;
            }
            else
            {
                return (((salarioAnual - 500000) * 0.30) + 87500) / 12;
            }
        }
        public double CalcularImpuestoRenta(double salarioMensual)
        {
            double salarioAnual = salarioMensual * 12;
            return CalcularImpuestoRentaAnual(salarioAnual);
        }

    }
}
