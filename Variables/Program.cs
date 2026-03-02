// 1. Declaración de Variables
string mensaje = "¡Bienvenido a C#!";
int anio = 2026;

// 2. Tipos numéricos con decimales
double valorPi = 3.14159;

// 'decimal' requiere el sufijo 'm'. Usado para DINERO (Alta precisión)
decimal precioProducto = 19.99m;

// 'float' requiere el sufijo 'f'. Usado para Gráficos/Videojuegos (Menos precisión)
float coordenadas = 5.45f;

// 3. Salida en consola (Moderno: Interpolación de Cadenas $)
// En lugar de {0}, usamos el signo $ para poner las variables directo en el texto.
Console.WriteLine($"{mensaje} - Año: {anio}");

Console.WriteLine("--------------------------------"); // Separador visual
Console.WriteLine($"Dato Científico (Double): {valorPi}");
Console.WriteLine($"Precio (Decimal):         ${precioProducto}");
Console.WriteLine($"Posición (Float):         {coordenadas}f");