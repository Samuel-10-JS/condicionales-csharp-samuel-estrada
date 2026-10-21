Console.WriteLine("Ingrese una letra: ");
string letra = Console.ReadLine()?.ToLower() ?? "";

if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine("Es una vocal");
}
else if (letra.Length == 1 && letra[0] >= 'a' && letra[0] <= 'z')
{
    Console.WriteLine("Es consonante");
}
else
{
    Console.WriteLine("Por favor, ingrese una letra válida.");
}