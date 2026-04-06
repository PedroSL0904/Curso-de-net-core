Console.WriteLine("--- Triángulo de Pascal ---");
Console.WriteLine("Ingrese el número de pisos:");
int pisos = Convert.ToInt16(Console.ReadLine());


int[] arregloAnterior = new int[0];

for (int i = 0; i < pisos; i++)
{

    int[] pascal = new int[i + 1];

    for (int j = pisos; j > i; j--)
    {
        Console.Write(" ");
    }


    for (int k = 0; k <= i; k++)
    {

        if (k == 0 || k == i)
        {
            pascal[k] = 1;
        }
        else
        {
            pascal[k] = arregloAnterior[k] + arregloAnterior[k - 1];
        }

        Console.Write(pascal[k] + " ");
    }

    arregloAnterior = pascal;

    Console.WriteLine();
}