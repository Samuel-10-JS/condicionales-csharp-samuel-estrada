Console.WriteLine("Ingrese índice de calidad del aire (ICA):");
if (int.TryParse(Console.ReadLine(), out int ica))
{
    string cat = ica switch
    {
        < 0 => "Valor inválido",
        <= 50 => "Buena",
        <= 100 => "Moderada",
        <= 150 => "Dañina para grupos sensibles",
        <= 200 => "Dañina",
        _ => "Muy dañina"
    };
    Console.WriteLine(cat);
}
else
{
    Console.WriteLine("Valor inválido");
}