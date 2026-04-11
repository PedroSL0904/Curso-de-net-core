Console.WriteLine("--- 1. Switch Clásico (Números) ---");
int nivel = 4;

switch (nivel)
{
    case 4:
    case 5:
        Console.WriteLine($"El nivel es válido: {nivel}");
        break;
    default:
        Console.WriteLine("Nivel inválido");
        break;
}

Console.WriteLine("\n--- 2. Switch Clásico (Textos) ---");
string nombreUsuario = "Pedro";

switch (nombreUsuario)
{
    case "Pedro":
        Console.WriteLine($"El administrador actual es: {nombreUsuario}");
        break;
    case "Maria":
        Console.WriteLine($"La supervisora es: {nombreUsuario}");
        break;
    default:
        break;
}

Console.WriteLine("\n--- 3. Switch Expressions (Asignación Directa) ---");
int estadoSistema = 2;

// Se asigna el valor directamente a la variable 'mensaje'
string mensaje = estadoSistema switch
{
    1 => "Estado 1: Sistema Iniciando...",
    2 => "Estado 2: Funcionando correctamente",
    _ => "Estado inválido" // El guión bajo (_) es el equivalente al 'default'
};
Console.WriteLine(mensaje);

// --- 4. Switch Expressions con Múltiples Variables (Tuplas) ---
Console.WriteLine("\n--- 4. Minicalculadora con Tuplas ---");
// Desestructuración de variables para hacerlo en una sola línea
var (numero1, numero2, operador) = (5, 3, "+");

string resultadoCalculadora = operador switch
{
    "+" => $"La suma es {numero1 + numero2}",
    "-" => $"La resta es {numero1 - numero2}",
    "*" => $"La multiplicación es {numero1 * numero2}",
    "/" => $"La división es {numero1 / numero2}",
    _ => "Operación no válida"
};
Console.WriteLine(resultadoCalculadora);