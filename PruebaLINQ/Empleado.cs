using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        // Clave foránea
        public int EmpresaId { get; set; }

        public override string ToString()
        {
            return string.Format("Empleado {0} con {1}, cargo {2} con salario {3}" +
                " pertence a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }
}
