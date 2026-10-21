Console.WriteLine("Seleccione una opcion: \n1) Consultar saldo\n2) Retirar\n3) Depositar\n4) Salir");
int opcion = int.Parse(Console.ReadLine() ?? "");

switch (opcion)
{
    case 1:
    Console.WriteLine("Seleccionastes Consultar saldo");
    break;

    case 2:
    Console.WriteLine("Seleccionaste Retirar");
    break;

    case 3:
    Console.WriteLine("Seleccionaste Depositar");
    break;

    case 4:
    Console.WriteLine("Saliendo...");
    break;
}