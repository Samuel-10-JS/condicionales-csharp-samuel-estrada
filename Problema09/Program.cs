Console.WriteLine("Ingresa un año: ");
int anio_bisiesto = int.Parse(Console.ReadLine() ?? "");

if ((anio_bisiesto % 4 == 0 && anio_bisiesto % 100 !=0) || anio_bisiesto % 400 == 0)
{
    Console.WriteLine("Año Bisiesto");
}
else
{
    Console.WriteLine("No es año bisiesto");
}
