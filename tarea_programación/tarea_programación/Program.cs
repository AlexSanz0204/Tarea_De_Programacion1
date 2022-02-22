//Hecho por: Alexander Enrique Zelaya Sánchez

using System;
using System.Collections.Generic;

class Ejemplo1
{
    public static void Main()
    {
        Stack<string> nombres = new Stack<string>();
        nombres.Push("Alexander");
        nombres.Push("Enrique");
        nombres.Push("Karen");
        nombres.Push("Gabriela");
        nombres.Push("Wendy");
        nombres.Push("José");

        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        Console.WriteLine("\nEliminando '{0}'", nombres.Pop());
        Console.WriteLine("\nItem a desapilar: {0}", nombres.Peek());
        Console.WriteLine("\nEliminando '{0}'", nombres.Pop());

        Stack<string> stack2 = new Stack<string>(nombres.ToArray());

        Console.WriteLine("\nPrimer copia: ");
        foreach (string nombre in stack2)
        {
            Console.WriteLine(nombre);
        }

        string[] array2 = new string[nombres.Count * 2];
        nombres.CopyTo(array2, nombres.Count);


        Stack<string> stack3 = new Stack<string>(array2);

        Console.WriteLine("\nSegunda copia,incluyendo duplicados y nulos: ");
        foreach (string nombre in stack3)
        {
            Console.WriteLine(nombre);
        }
        Console.WriteLine("\nVerificando si contiene la pila numero 2  contiene el nombre Manuel");
        Console.WriteLine("\nLa pila numero 2 contiene (\"Manuel\") = {0}",
            stack2.Contains("Manuel"));
        Console.WriteLine("\nLimpiando la pila numero 2");
        stack2.Clear();
        Console.WriteLine("\n{0}", stack2.Count);
    }
}
