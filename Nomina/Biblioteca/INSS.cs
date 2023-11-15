using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina.Biblioteca
{
    internal class INSS
    {
        public double CalcularINSS(double salario)
        {
            return (salario * 0.07);
        }
    }
}
