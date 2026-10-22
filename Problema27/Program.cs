Console.WriteLine("Ingrese día de la semana (lunes...domingo):");
string dia = Console.ReadLine()?.Trim().ToLower() ?? "";
Console.WriteLine("¿Es estudiante? (s/n):");
bool estudiante = (Console.ReadLine()?.Trim().ToLower() ?? "") is "s" or "si";

int precio = dia switch
{
    "martes" => 7000,
    "sabado" or "sábado" or "domingo" => 15000,
    _ => estudiante ? 9000 : 12000
};
Console.WriteLine($"Precio de la boleta: ${precio:N0}");