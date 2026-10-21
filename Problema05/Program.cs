Console.WriteLine("Ingrese un numero entero");
int n1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingrese otro numero entero");
int n2 = int.Parse(Console.ReadLine() ?? "");

int mayor = (n1 > n2) ? n1 : n2;

Console.WriteLine($"El numero mayor es: {mayor}");