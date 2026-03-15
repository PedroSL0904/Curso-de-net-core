Console.WriteLine("Operadores Aritméticos en C#");

int valor = 3;
int valor2 = 6;
var suma = valor + valor2; // operador de suma
var resta = valor - valor2; // operador de resta
var producto = valor * valor2; // operador de multiplicación
var division = (double)valor / valor2; // operador de división
var modulo = valor % valor2; // operador de módulo
Console.WriteLine($"La suma de {valor} y {valor2} es: {suma}");
Console.WriteLine($"La resta de {valor} y {valor2} es: {resta}");
Console.WriteLine($"El producto de {valor} y {valor2} es: {producto}");
Console.WriteLine($"La división de {valor} y {valor2} es: {division}");
Console.WriteLine($"El módulo de {valor} y {valor2} es: {modulo}");

Console.WriteLine("\nOperadores de Asignación en C#");

valor  = 2; // operador de asignación
valor += valor2; // operador de asignación de suma
Console.WriteLine($"El valor después de la asignación es: {valor}");
valor -= valor2; // operador de asignación de resta
Console.WriteLine($"El valor después de la resta es: {valor}");
valor *= valor2; // operador de asignación de multiplicación
Console.WriteLine($"El valor después de la multiplicación es: {valor}");
valor /= valor2; // operador de asignación de división
Console.WriteLine($"El valor después de la división es: {valor}");
valor %= valor2; // operador de asignación de módulo
Console.WriteLine($"El valor después del módulo es: {valor}");
Console.WriteLine("\nOperadores de comprobación de tipos y relacionales");

var data = valor < valor2; // operador de comparación menor que
Console.WriteLine($"¿Es {valor} menor que {valor2}? {data}");
data = valor > valor2; // operador de comparación mayor que
Console.WriteLine($"¿Es {valor} mayor que {valor2}? {data}");
data = valor <= valor2; // operador de comparación menor o igual que
Console.WriteLine($"¿Es {valor} menor o igual que {valor2}? {data}");
data = valor >= valor2; // operador de comparación mayor o igual que
Console.WriteLine($"¿Es {valor} mayor o igual que {valor2}? {data}");

Console.WriteLine("\nOperadores de igualdad y desigualdad");
data = valor == valor2; // operador de igualdad
Console.WriteLine($"¿Es {valor} igual a {valor2}? {data}");
data = valor != valor2; // operador de desigualdad
Console.WriteLine($"¿Es {valor} diferente a {valor2}? {data}");