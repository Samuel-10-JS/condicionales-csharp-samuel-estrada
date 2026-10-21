object dato = 57230.4242;

switch (dato)
{
    case string texto:
        Console.WriteLine($"El texto tiene {texto.Length} caracteres");
    break;

    case int Entero:
        Console.WriteLine($"Entero {Entero}");
    break;

    case double decimales:
        Console.WriteLine($"Decimales {decimales}");
    break;

    case bool booleano:
        Console.WriteLine($"Booleano {booleano}");
    break;

    default:
        Console.WriteLine("Tipo de dato no reconocido");
    break;              
}