// 1. Declaración de Variables
string mensaje = "¡Bienvenido a C#!";
int anio = 2026;

// 2. Tipos numéricos con decimales
double valorPi = 3.14159;

// 'decimal' requiere el sufijo 'm'. Usado para DINERO (Alta precisión)
decimal precioProducto = 19.99m;

// 'float' requiere el sufijo 'f'. Usado para Gráficos/Videojuegos (Menos precisión)
float coordenadas = 5.45f;

// 'bool' representa un valor verdadero o falso
bool esSoltero = true;

// 'char' representa un solo carácter. Se define con comillas simples
char letraInicial = 'P';

// 3. Salida en consola 
Console.WriteLine($"{mensaje} - Año: {anio}");
Console.WriteLine("--------------------------------"); 
Console.WriteLine($"Dato Científico (Double):  {valorPi}");
Console.WriteLine($"Precio (Decimal):          ${precioProducto}");
Console.WriteLine($"Posición (Float):          {coordenadas}f");
Console.WriteLine($"Estado Civil (Bool):       {esSoltero}");
Console.WriteLine($"Letra Inicial (Char):      '{letraInicial}'");