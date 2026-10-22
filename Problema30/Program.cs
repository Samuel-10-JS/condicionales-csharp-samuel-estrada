Console.WriteLine("Ingrese nota 1 (0-100):");
double.TryParse(Console.ReadLine(), out double n1);
Console.WriteLine("Ingrese nota 2 (0-100):");
double.TryParse(Console.ReadLine(), out double n2);
Console.WriteLine("Ingrese nota 3 (0-100):");
double.TryParse(Console.ReadLine(), out double n3);

double promedio = (n1 + n2 + n3) / 3.0;
char letra = promedio switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retro = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    _ => "Debe presentar plan de mejoramiento"
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
string mencion = promedio == 100 ? " | ¡Mención de honor!" : "";

Console.WriteLine($"Promedio: {promedio:F1} | Letra: {letra} | {retro} | {estado}{mencion}");