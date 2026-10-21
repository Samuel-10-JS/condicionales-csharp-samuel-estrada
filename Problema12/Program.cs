Console.WriteLine("¿Tiene empleo? (s/n):");
string tieneEmpleo = Console.ReadLine()?.Trim().ToLower() ?? "";
if (tieneEmpleo != "s" && tieneEmpleo != "si")
{
    Console.WriteLine("Credito rechazado");
}
else
{
    Console.WriteLine("Ingrese su ingreso mensual:");
    if (decimal.TryParse(Console.ReadLine(), out decimal ingreso))
    {
        if (ingreso >= 2500000)
            Console.WriteLine("Credito alto aprobado");
        else
            Console.WriteLine("Credito básico aprobado");
    }
    else
    {
        Console.WriteLine("Ingreso invalido");
    }
}