Console.WriteLine("Cual es el porcentaje de tu bateria: ");
string input = Console.ReadLine() ?? "";
int bateria = int.Parse(input);

if (bateria < 15)
{
    Console.WriteLine($"Bateria Baja {bateria}%");
    
}
else
{
    Console.WriteLine($"Tu porcentaje de bateria es: {bateria}%");
}