Console.WriteLine("Ingrese categoría del vehículo (M, A, B, C):");
char cat = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();

try
{
    (string veh, int tarifa) = cat switch
    {
        'M' => ("Moto", 0),
        'A' => ("Automóvil", 12000),
        'B' => ("Bus", 25000),
        'C' => ("Camión", 38000),
        _ => throw new Exception("Categoría desconocida")
    };
    Console.WriteLine($"Categoría {cat} - Tarifa: ${tarifa:N0}");
}
catch (Exception ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}