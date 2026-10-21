Console.WriteLine("1) Piedra\n2) Papel\n3) Tijeras");
string j1 = Console.ReadLine()?.ToLower() ?? "";

Console.WriteLine("1) Piedra\n2) Papel\n3) Tijeras");
string j2 = Console.ReadLine()?.ToLower() ?? "";

if (j1 == j2)
{
    Console.WriteLine("Empate");
}

else if ((j1 == "piedra" && (j2 == "tijera" || j2 == "tijeras")) || 
         (j1 == "papel" && j2 == "piedra") || 
         (j1 == "tijeras" && j2 == "papel"))
{
    Console.WriteLine("Jugador 1 es el ganador");
}
else
{
    Console.WriteLine("Jugador 2 es el ganador");
}