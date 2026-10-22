Console.WriteLine("Ingrese velocidad en km/h:");
if (int.TryParse(Console.ReadLine(), out int vel))
{
    string sancion = vel switch
    {
        < 0 => "Lectura inválida",
        <= 50 => "Sin infracción",
        <= 70 => "Multa leve",
        <= 90 => "Multa grave",
        _ => "Multa gravísima e inmovilización"
    };
    Console.WriteLine(sancion);
}
else
{
    Console.WriteLine("Velocidad inválida");
}