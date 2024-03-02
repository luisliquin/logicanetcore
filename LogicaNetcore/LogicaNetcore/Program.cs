using ValidationLibrary;

string[] fracciones = { "4/6", "10/11", "100/400" };
string[] nombres = { "E. Poe", "E. A. Poe", "Edgard A. Poe", "Edgard", "e. Poe", "E Poe", "E. Allan Poe", "E. A. P.", "Edg. A. Poe" };

Console.WriteLine("Simplificación de Fracciones y Validación de Nombres");

foreach (var fraccion in fracciones)
{
    Console.WriteLine($"Simplificar {fraccion} = {FractionSimplifier.Simplify(fraccion)}");
}

foreach (var nombre in nombres)
{
    Console.WriteLine($"ValidName(\"{nombre}\") ➞ {NameValidator.ValidName(nombre)}");
}