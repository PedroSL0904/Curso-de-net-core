// --- 1. Bucle 'for' Incremental ---
Console.WriteLine("--- Contador hacia arriba ---");
// Ejecuta el bloque mientras 'i' sea menor que 10 (del 0 al 9)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}

// --- 2. Bucle 'for' Decremental ---
Console.WriteLine("\n--- Contador hacia abajo ---");
// Inicia en 10 y resta 1 en cada vuelta hasta llegar a 1
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"Valor de i: {i}");
}

// --- 3. Recorrer múltiples arreglos simultáneamente ---
Console.WriteLine("\n--- Lectura de Arreglos Paralelos ---");
// Usamos nombres en plural porque guardan colecciones de datos
string[] nombres = { "Juan", "María", "Pedro" };
int[] edades = { 25, 30, 35 };

// Usamos .Length para asegurar que el ciclo se adapte al tamaño del arreglo
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine($"Nombre: {nombres[i]} | Edad: {edades[i]} años");
}

// --- 4. Bucle 'foreach' (El método elegante) ---
Console.WriteLine("\n--- Recorrido Rápido con foreach ---");
// Extrae automáticamente cada elemento sin necesidad de usar un índice numérico
foreach (string persona in nombres)
{
    Console.WriteLine($"Nombre: {persona}");
}