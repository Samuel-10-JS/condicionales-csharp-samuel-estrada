Console.WriteLine("Ingres un numero entero: ");
int Numero = int.Parse(Console.ReadLine() ?? "");

if (Numero < 0)
{
    Console.WriteLine("Este numero es negativo");
}
else if (Numero > 0)
{
    Console.WriteLine("Este numero es positivo");
}
else
{
    Console.WriteLine("Cero");
}