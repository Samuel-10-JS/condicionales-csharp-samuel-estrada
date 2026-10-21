Console.WriteLine("Ingrese estatura en metros (ej. 1.45):");
double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double estatura);
Console.WriteLine("Ingrese edad:");
int.TryParse(Console.ReadLine(), out int edad);
Console.WriteLine("¿Va acompañado por un adulto? (s/n):");
bool acompañado = (Console.ReadLine()?.Trim().ToLower() ?? "") is "s" or "si";

if (estatura >= 1.40 && (edad >= 12 || acompañado))
    Console.WriteLine("Puede subir");
else
    Console.WriteLine("No puede subir");