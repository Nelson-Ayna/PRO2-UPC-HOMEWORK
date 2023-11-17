class Program
{
    static void Main()
    {
        ArrayEntero arrayEnteroA = new ArrayEntero(5);
        arrayEnteroA.Elementos[0] = 1;
        arrayEnteroA.Elementos[1] = 9;
        arrayEnteroA.Elementos[2] = 10;
        arrayEnteroA.Elementos[3] = 2;
        arrayEnteroA.Elementos[4] = 7;

        ArrayEntero arrayEnteroB = new ArrayEntero(3);
        arrayEnteroB.Elementos[0] = 10;
        arrayEnteroB.Elementos[1] = 90;
        arrayEnteroB.Elementos[2] = 100;

        ArrayCadena arrayCadenaA = new ArrayCadena(4);
        arrayCadenaA.Elementos[0] = "Ereli";
        arrayCadenaA.Elementos[1] = "Maria";
        arrayCadenaA.Elementos[2] = "Ines";
        arrayCadenaA.Elementos[3] = "Joel";

        ArrayCadena arrayCadenaB = new ArrayCadena(5);
        arrayCadenaB.Elementos[0] = "Douglas";
        arrayCadenaB.Elementos[1] = "Ereli";
        arrayCadenaB.Elementos[2] = "Suarez";
        arrayCadenaB.Elementos[3] = "Maria";
        arrayCadenaB.Elementos[4] = "Joel";

        Console.WriteLine($"---------------------------------");
        arrayEnteroA.MostrarMaxMin();
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Suma: {arrayEnteroA.Suma()}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Promedio: {arrayEnteroA.Promedio()}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Frecuencia Elemento: {arrayEnteroA.Frecuencia(10)}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Buscar Elemento: {arrayCadenaA.BuscarElemento("Ereli")}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Frecuencia Elemento: {arrayCadenaA.Frecuencia("Ereli")}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Complemento: {string.Join(", ", arrayCadenaA.Complemento(arrayCadenaB))}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"ArrayCadena to ArrayEntero: {string.Join(", ", arrayCadenaA.ArrayCadenaToArrayEntero())}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Diferencia: {string.Join(", ", arrayCadenaA.Diferencia(arrayCadenaB))}");
        Console.WriteLine($"---------------------------------");
        arrayCadenaA.Invertir();
    }
}
