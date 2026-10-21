Console.WriteLine("Cual es tu edad: ");
string input = Console.ReadLine() ?? "";
int edad = int.Parse(input);

if (edad < 18)
{
    Console.WriteLine("Aun no puede votar");
}
else
{
    Console.WriteLine("Puede votar");
}