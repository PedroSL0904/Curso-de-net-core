Console.WriteLine("--- 1. Concatenación e Interpolación ---");
string nombre1 = "Pedro";
string nombre2 = "Juan";
nombre1 += nombre2; 
Console.WriteLine($"Nombre concatenado: {nombre1}");

var persona = (Nombre: "Pedro", Apellido: "Sánchez", Edad: 25);
Console.WriteLine($"Nombre con tupla: {persona.Nombre} {persona.Apellido} ({persona.Edad} años)");


Console.WriteLine("\n--- 2. Extracción y Modificación ---");
string curso = "Curso de C# desde cero";
Console.WriteLine($"Texto original: {curso}");

string textoExtraido = curso.Substring(9, 11);
Console.WriteLine($"Substring (9, 11): {textoExtraido}");

string textoReemplazado = curso.Replace("desde cero", ".NET Core");
Console.WriteLine($"Replace: {textoReemplazado}");

string textoRecortadoInicio = curso.Remove(5);
Console.WriteLine($"Remove (todo desde el índice 5): {textoRecortadoInicio}");

string textoRecortadoMedio = curso.Remove(5, 11);
Console.WriteLine($"Remove (11 caracteres desde el índice 5): {textoRecortadoMedio}");


Console.WriteLine("\n--- 3. Búsqueda y Comparación ---");
int indiceBusqueda = curso.IndexOf("C#");
Console.WriteLine($"La posición de 'C#' es: {indiceBusqueda}");

bool esIgual = curso.Equals("Curso de C# desde cero");
Console.WriteLine($"¿El curso es exactamente igual al texto dado? {esIgual}");


Console.WriteLine("\n--- 4. Formateo y Arreglos ---");
string textoMayusculas = curso.ToUpper();
Console.WriteLine($"ToUpper: {textoMayusculas}");

Console.WriteLine("\nRecorriendo la cadena letra por letra:");
foreach (char letra in curso)
{
    Console.Write(letra + "-");
}
Console.WriteLine(); 