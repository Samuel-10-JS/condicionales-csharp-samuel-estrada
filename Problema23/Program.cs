Console.WriteLine("Ingrese usuario:");
string user = Console.ReadLine()?.Trim() ?? "";
if (user != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else
{
    Console.WriteLine("Ingrese contraseña:");
    string pass = Console.ReadLine()?.Trim() ?? "";
    if (pass == "Sena2026")
        Console.WriteLine("Bienvenido");
    else
        Console.WriteLine("Contraseña incorrecta");
}