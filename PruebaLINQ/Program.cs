// 1. Obtener el origen de datos.
using PruebaLINQ;

int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6 };

// 2. Crear la consulta.
// numPares es un IEnumerable<int>

IEnumerable<int> numPares = from num in numeros
                            where num % 2 == 0
                            select num;

// 3. Ejecutar la consulta.
foreach(int num in numPares)
    Console.Write("{0,1} ", num);

Console.WriteLine("---------------");
ControlEmpleadosEmpresa cee = new ControlEmpleadosEmpresa();
Console.WriteLine("Obtener CEO");
cee.ObtenerCEO();
int empresa = 4;
string emp = "Google";
Console.WriteLine("Obtener empleados de empresa "+ emp);
cee.ObtenerEmpleadosEmpresa(emp);

Console.WriteLine("Obtener empleados salario < 15000");
cee.ObtenerSalarioMenor15000();