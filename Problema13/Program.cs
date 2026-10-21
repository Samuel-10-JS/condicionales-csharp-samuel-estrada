Console.WriteLine("Ingrese codigo de pais (ej. CO, MX, AR, PE, CL):");
string codigo = Console.ReadLine()?.Trim().ToUpper() ?? "";
string pais = codigo switch
{
    "CO" => "Colombia",
    "MX" => "Mexico",
    "AR" => "Argentina",
    "PE" => "Peru",
    "CL" => "Chile",
    _ => "Pais no registrado"
};
Console.WriteLine(pais);