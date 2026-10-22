Console.WriteLine("Ingrese valor de la compra:");
if (decimal.TryParse(Console.ReadLine(), out decimal compra))
{
    Console.WriteLine("¿Es cliente frecuente? (s/n):");
    bool frecuente = (Console.ReadLine()?.Trim().ToLower() ?? "") is "s" or "si";

    decimal descBase = compra switch
    {
        >= 500000 => 0.15m,
        >= 200000 => 0.10m,
        >= 100000 => 0.05m,
        _ => 0.0m
    };

    decimal descAdicional = (frecuente && compra >= 100000) ? 0.05m : 0.0m;
    decimal descTotal = descBase + descAdicional;
    decimal total = compra * (1 - descTotal);

    Console.WriteLine($"Compra: ${compra:N0} | Descuento: {descTotal * 100}% | Total a pagar: ${total:N0}");
}
else
{
    Console.WriteLine("Valor inválido");
}