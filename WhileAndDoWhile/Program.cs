Console.WriteLine("--- Ciclo while ---");
int contador = 1;

while (contador <= 6)
{
    Console.WriteLine($"Iteración while: {contador}");
    contador++; 
}

Console.WriteLine("\n--- 2. Ciclo do-while ---");
int intentos = 1;

do
{
    Console.WriteLine($"Iteración do-while: {intentos}");
    intentos++;
} while (intentos <= 6);


Console.WriteLine("\n--- 3. Ciclo while ---");
bool sistemaActivo = true;
int tiempo = 1;

while (sistemaActivo)
{
    Console.WriteLine($"Monitoreando máquina... segundo {tiempo}");

    if (tiempo == 3) 
    {
        Console.WriteLine("¡Falla detectada! Apagando monitoreo...");
        sistemaActivo = false; 
        // break;
    }

    tiempo++;
}