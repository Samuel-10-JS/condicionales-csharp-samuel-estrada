Console.WriteLine("Ingrese primer número entero:");
int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Ingrese segundo número entero:");
int.TryParse(Console.ReadLine(), out int b);
Console.WriteLine("Ingrese operador (+, -, *, /):");
char op = Console.ReadKey().KeyChar;
Console.WriteLine();

try
{
    double res = op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => b == 0 ? throw new DivideByZeroException("No se puede dividir entre cero") : (double)a / b,
        _ => throw new InvalidOperationException("Operador no soportado")
    };
    Console.WriteLine($"{a} {op} {b} = {res}");
}
catch (Exception ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}