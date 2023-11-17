using System;
using System.Linq;

public class ArrayEntero
{
    public int[] Elementos { get; set; }

    public ArrayEntero(int size)
    {
        Elementos = new int[size];
    }

    public void MostrarMaxMin()
    {
        int max = Elementos.Max();
        int min = Elementos.Min();
        Console.WriteLine($"Máximo: {max}, Mínimo: {min}");
    }

    public int Suma()
    {
        return Elementos.Sum();
    }

    public double Promedio()
    {
        return Elementos.Average();
    }

    public int Frecuencia(int elemento)
    {
        return Elementos.Count(x => x == elemento);
    }

    public string[] ArrayEnteroToArrayCadenas()
    {
        return Elementos.Select(i => ((char)i).ToString()).ToArray();
    }
}
