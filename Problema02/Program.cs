Console.WriteLine("Ingresa el Peso del Paquete: ");
string input = Console.ReadLine() ?? "";
double Peso_Paquete = double.Parse(input);
decimal tarifa = 0;

if (Peso_Paquete <= 0)
{
  Console.WriteLine("Peso no valido");
  tarifa = 0;  
}
else if (Peso_Paquete < 1)
{
    tarifa = 8000;
}
else if (Peso_Paquete < 5)
{
    tarifa = 15000;
}
else if (Peso_Paquete < 20)
{
    tarifa = 32000;
}
else
{
    tarifa = 60000;
}

Console.WriteLine($"La tarifa de envio es: {tarifa}");