using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class ControlEmpleadosEmpresa
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpleadosEmpresa()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google"});
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Microsoft"});
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Sony"});
            listaEmpresas.Add(new Empresa { Id = 4, Nombre = "Apple"});
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Owen Espinoza", Cargo= "CEO", EmpresaId = 1, Salario = 15000});
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Diana Chavarría", Cargo= "CEO", EmpresaId = 2, Salario = 15000});
        }
    }
}
