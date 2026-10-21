Console.WriteLine("Ingrese coordenada X:");
int.TryParse(Console.ReadLine(), out int x);
Console.WriteLine("Ingrese coordenada Y:");
int.TryParse(Console.ReadLine(), out int y);

if (x == 0 && y == 0)
    Console.WriteLine("Origen");
else if (x == 0 || y == 0)
    Console.WriteLine("Sobre un eje");
else if (x > 0 && y > 0)
    Console.WriteLine("Primer cuadrante");
else if (x < 0 && y > 0)
    Console.WriteLine("Segundo cuadrante");
else if (x < 0 && y < 0)
    Console.WriteLine("Tercer cuadrante");
else
    Console.WriteLine("Cuarto cuadrante");