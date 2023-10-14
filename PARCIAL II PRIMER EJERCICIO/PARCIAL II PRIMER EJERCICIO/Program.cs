//EJERCICIO 1
Console.WriteLine("Bienvenido al Sistema");
Console.WriteLine("Favor ingrese la clave principal:");

string ClavePrincipal = "AdministradoR";
string Clave = Console.ReadLine();

if (ValidarConstraseña(Clave, ClavePrincipal))
{
    Console.WriteLine("Acceso aceptado.  Puede realizar las configuraciones de respaldo.");
}
else
{
    Console.WriteLine("Acceso rechazado. La clave ingresada no es válida.");
}

static string N(string input)
{
    return input.Trim().ToLower();
}

static bool ValidarConstraseña(string input, string Password)
{
    return N(input) == N(Password);
}