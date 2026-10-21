Console.WriteLine("Ingrese nota final (0 a 5):");
if (double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double nota))
{
    string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";
    Console.WriteLine($"Nota: {nota} - {estado}");
}
else
{
    Console.WriteLine("Nota invalida");
}