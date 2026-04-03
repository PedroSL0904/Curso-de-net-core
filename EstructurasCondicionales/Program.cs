int valor1 = 10;
int valor2 = 20;
int valor3 = 30;
int valor4 = 40;

bool sonDiferentes = valor1 != valor2;

Console.WriteLine("--- 1. Estructura if / else if / else ---");
if (valor1 == valor2)
{
    Console.WriteLine($"{valor1} es igual a {valor2}");
}
else if (valor1 > valor2)
{
    Console.WriteLine($"{valor1} es mayor que {valor2}");
}
else
{
    Console.WriteLine($"{valor1} es menor que {valor2}");
}

Console.WriteLine("\n--- 2. Operadores Lógicos (AND && / OR ||) ---");
if (valor1 < valor2 && valor1 != 10)
{
    Console.WriteLine($"{valor1} es menor que {valor2} y no es igual a 10");
}
else
{
    Console.WriteLine($"{valor1} no es menor que {valor2} o es igual a 10");
}

if (valor1 < valor2 || valor3 > valor4)
{
    Console.WriteLine($"{valor1} es menor que {valor2} o {valor3} es mayor que {valor4}");
}
else
{
    Console.WriteLine($"{valor1} no es menor que {valor2} y {valor3} no es mayor que {valor4}");
}

Console.WriteLine("\n--- 3. if anidado ---");
if (sonDiferentes)
{

    Console.WriteLine("La condición inicial es verdadera.");

    if (valor3 == valor4)
    {
        Console.WriteLine($"   -> Además, {valor3} es igual a {valor4}");
    }
    else
    {
        Console.WriteLine($"   -> Sin embargo, {valor3} no es igual a {valor4}");
    }
}
else
{
    Console.WriteLine("La condición inicial es falsa.");
}

Console.WriteLine("\n--- 4. Operador condicional (Ternario) ---");
string name = sonDiferentes ? "Pedro" : "Juan";

Console.WriteLine($"El nombre es: {name}");