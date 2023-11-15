namespace Nomina.Biblioteca
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, string apellido, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Salario = salario;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}