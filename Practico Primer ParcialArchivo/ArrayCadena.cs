using System;
using System.Linq;

public class ArrayCadena
{
    public string[] Elementos { get; set; }

    public ArrayCadena(int size)
    {
        Elementos = new string[size];
    }

    public string BuscarElemento(string elemento)
    {
        return Elementos.Contains(elemento) ? "TRUE" : "FALSE";
    }

    public int Frecuencia(string elemento)
    {
        return Elementos.Count(x => x == elemento);
    }

    public string[] Complemento(ArrayCadena arrayB)
    {
        return Elementos.Except(arrayB.Elementos).ToArray();
    }

    public int[] ArrayCadenaToArrayEntero()
    {
        return Elementos.SelectMany(s => s.Select(c => (int)c)).ToArray();
    }

    public void Invertir()
    {
        Array.Reverse(Elementos);
        Console.WriteLine(string.Join(", ", Elementos));
    }

    public string[] Diferencia(ArrayCadena arrayB)
    {
        return arrayB.Elementos.Except(Elementos).ToArray();
    }
}
