using System;

public class SerieDomino
{
    // Método recursivo para imprimir la serie del dominó
    // Parámetros:
    // - inicio: primer número del par
    // - fin: segundo número del par
    // - N: longitud total de la serie
    public static void ImprimirSerieDomino(int inicio, int fin, int N)
    {
        // Caso base: cuando la longitud de la serie es 0, no hacemos nada
        if (N == 0)
        {
            return;
        }
        else
        {
            // Llamada recursiva con los valores actualizados de inicio, fin y N
            ImprimirSerieDomino(inicio + 1, fin - 1, N - 1);

            // Imprimir el par actual
            Console.WriteLine("Serie: (" + inicio + "," + fin + ")");
        }
    }

    public static void Main()
    {
        // Iniciar la serie del dominó con valores iniciales
        Console.WriteLine("Serie del dominó:");

        // Llamar al método recursivo con valores iniciales y longitud 5
       ImprimirSerieDomino(1, 6, 5);
    }
}
