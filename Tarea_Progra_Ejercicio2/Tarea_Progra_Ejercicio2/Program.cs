//Hecho por: Alexander Enrique Zelaya Sánchez

using System;
using System.Collections;
public class Ejemplo2
{

    public static void Main()
    {
        Queue miQ = new Queue();
        miQ.Enqueue(1);
        miQ.Enqueue(2);
        miQ.Enqueue(3);
        miQ.Enqueue(4);
        miQ.Enqueue(5);

        Console.WriteLine("\nElementos guardados: ");
        Console.WriteLine("\n{0}", miQ.Count);
        Console.Write("\nValores de la cola: ");
        PrintValues(miQ);

        Console.WriteLine("Removiendo un elemento: \n{0}", miQ.Dequeue());

        Console.Write("\nMostrando valores: ");
        PrintValues(miQ);


        Console.WriteLine("Removiendo otro elemento: \n{0}", miQ.Dequeue());


        Console.Write("\nMostrando valores actualizados: ");
        PrintValues(miQ);


        Console.WriteLine("\nMostrando primer elemento sin haber sido removidos\n{0}", miQ.Peek());

        Console.Write("\nMostrando los valores actualizados: ");
        PrintValues(miQ);

        miQ.Clear();

        Console.WriteLine("\nlos valores han sido Limpiados");
        Console.WriteLine("\n{0}", miQ.Count);
        Console.Write("\nValores en la cola:");
        PrintValues(miQ);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("\n {0}", obj);
        Console.WriteLine();
    }
}
