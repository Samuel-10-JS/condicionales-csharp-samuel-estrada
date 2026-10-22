Console.WriteLine("Ingrese día de la semana (1 = lunes ... 7 = domingo):");
if (int.TryParse(Console.ReadLine(), out int dia))
{
    string tipo = dia switch
    {
        >= 1 and <= 5 => "Día hábil",
        6 or 7 => "Fin de semana",
        _ => "Día inválido"
    };
    Console.WriteLine(tipo);
}
else
{
    Console.WriteLine("Día inválido");
}