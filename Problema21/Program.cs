Console.WriteLine("Ingrese cantidad de artículos en el carrito:");
if (int.TryParse(Console.ReadLine(), out int cant))
{
    string msg = $"Tienes {cant} artículo{(cant == 1 ? "" : "s")} en el carrito";
    Console.WriteLine(msg);
}
else
{
    Console.WriteLine("Cantidad inválida");
}