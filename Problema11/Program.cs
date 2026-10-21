Console.WriteLine("Ingrese estado del semáforo (Rojo, Amarillo, Verde):");
string estado = Console.ReadLine()?.Trim().ToLower() ?? "";
switch (estado)
{
    case "rojo": Console.WriteLine("Deténgase"); break;
    case "amarillo": Console.WriteLine("Precaución, prepárese para detenerse"); break;
    case "verde": Console.WriteLine("Avance"); break;
    default: Console.WriteLine("Estado no válido"); break;
}