using PruebaColeccionesGenericas;

List<int> valores = new List<int>();

valores.Add(1);
valores.Add(2);
valores.Add(3);
valores.Add(4);
valores.Add(5);

foreach(var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("------");

Console.WriteLine(valores.Contains<int>(5));
Console.WriteLine(valores.Contains<int>(17));

Console.WriteLine("-----");

Console.WriteLine(valores.IndexOf(4));

Console.WriteLine("-----");

valores.Insert(2, 55);

foreach (var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----");

//valores.Remove(2);
valores.RemoveAt(2);

foreach (var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----");

valores.Reverse();

foreach (var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----");

valores.Sort();

foreach (var valor in valores)
    Console.WriteLine(valor);

Console.WriteLine("-----");

List<Punto> listaPuntos = new List<Punto>();

listaPuntos.Add(new Punto(5, 3));
listaPuntos.Add(new Punto(7, 8));
listaPuntos.Add(new Punto(12, 5));
listaPuntos.Add(new Punto(6, 2));

foreach(Punto punto in listaPuntos)
    Console.WriteLine(punto);

Console.WriteLine("-----");

listaPuntos.Insert(2, new Punto(3, 4));

foreach (Punto punto in listaPuntos)
    Console.WriteLine(punto);

Console.WriteLine("-----");

Punto[] arregloPuntos = listaPuntos.ToArray();

for(int i = 0; i < arregloPuntos.Length; i++)
    Console.WriteLine(arregloPuntos[i]);

Console.WriteLine("-----");

listaPuntos.Sort();