Console.WriteLine("--- 1. Arreglos Unidimensionales (1D) ---");

string[] nombres = { "Pedro", "María", "Juan", "Ana", "Luis" };
int[] edades = { 25, 30, 35, 40, 45 };

Console.WriteLine($"La longitud del arreglo nombres es: {nombres.Length}");

Console.WriteLine($"Nombres: {string.Join(", ", nombres)}");
Console.WriteLine($"Edades:  {string.Join(", ", edades)}");


Console.WriteLine("\n--- 2. Arreglos Bidimensionales (2D - Matrices) ---");
double[,] matrizDoble = {
    { 6.0, 3.0 },
    { 6.3, 5.6 }
};

Console.WriteLine($"Fila 0: [ {matrizDoble[0, 0]} , {matrizDoble[0, 1]} ]");
Console.WriteLine($"Fila 1: [ {matrizDoble[1, 0]} , {matrizDoble[1, 1]} ]");


Console.WriteLine("\n--- 3. Arreglos Tridimensionales (3D - Cubos de Datos) ---");
double[,,] cuboTriple = {
    { { 6.0, 3.0, 8.9 }, { 6.3, 5.6, 1.1 } },
    { { 7.1, 8.2, 9.2 }, { 9.3, 10.4, 4.1 } }
};

Console.WriteLine($"Capa 0, Fila 0: [ {cuboTriple[0, 0, 0]} , {cuboTriple[0, 0, 1]} , {cuboTriple[0, 0, 2]} ]");
Console.WriteLine($"Capa 0, Fila 1: [ {cuboTriple[0, 1, 0]} , {cuboTriple[0, 1, 1]} , {cuboTriple[0, 1, 2]} ]");
Console.WriteLine($"Capa 1, Fila 0: [ {cuboTriple[1, 0, 0]} , {cuboTriple[1, 0, 1]} , {cuboTriple[1, 0, 2]} ]");