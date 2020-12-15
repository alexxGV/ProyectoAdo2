using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAdo.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public String Apellido { get; set; }
        public String Oficio { get; set; }
        public int Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }

        public int Dept_NO { get; set; }
    }
}
