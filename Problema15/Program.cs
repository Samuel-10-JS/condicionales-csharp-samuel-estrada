Console.WriteLine("Ingrese peso en kg:");
bool pOk = double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double peso);
Console.WriteLine("Ingrese estatura en metros:");
bool eOk = double.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double estatura);

if (pOk && eOk && estatura > 0)
{
    double imc = peso / (estatura * estatura);
    string categoria = imc switch
    {
        < 18.5 => "Bajo peso",
        < 25.0 => "Peso normal",
        < 30.0 => "Sobrepeso",
        _ => "Obesidad"
    };
    Console.WriteLine($"IMC: {imc:F1} - {categoria}");
}
else
{
    Console.WriteLine("Datos inválidos");
}