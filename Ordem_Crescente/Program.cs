using System;
using System.Linq; // <-- Não esquecer de importar a classe Linq

public class Program
{
    public static void Main()
    {
        // Array List não ordenado
        int[] numeros = { 1, 2, 3, 9, 8, 9, 6, 7, 5, 4, 6 };
        // Remove valores duplicados
        int[] retiraDuplicados = numeros.Distinct().ToArray();
        // Ordenar valores em ordem crescente 
        int[] ordemCrescente = numeros.OrderBy(x => x).ToArray();
        int[] ordemCrescenteSemDuplicidade = retiraDuplicados.OrderBy(x => x).ToArray();

        Console.WriteLine("\n\nNova Array sem duplicidade:");
        foreach (int item in retiraDuplicados)
        {
            Console.WriteLine(item);
        }
      
        Console.WriteLine("\n \n Ordem Crescente");
        foreach (int item in ordemCrescenteSemDuplicidade)
        {
            Console.WriteLine(item);
        }
    }
}