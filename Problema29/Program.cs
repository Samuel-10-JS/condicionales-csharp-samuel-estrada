Console.WriteLine("Ingrese rol (admin, instructor, aprendiz):");
string rol = Console.ReadLine()?.Trim().ToLower() ?? "";
Console.WriteLine("Ingrese hora de llegada (0 a 23):");
if (int.TryParse(Console.ReadLine(), out int hora) && hora >= 0 && hora <= 23)
{
    bool permitido = rol switch
    {
        "admin" => true,
        "instructor" => hora >= 6 && hora <= 21,
        "aprendiz" => hora >= 6 && hora <= 18,
        _ => false
    };

    Console.WriteLine(permitido ? "Acceso permitido" : "Acceso denegado");
}
else
{
    Console.WriteLine("Hora inválida");
}