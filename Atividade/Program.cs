using System;
using MinhaBiblioteca;

class Program
{
    static double mediaValoresVetor(int[] array)
    {
        double soma = 0;
        for (int i = 0; i <array.Length; i++)
        {
            soma += array[i];
        }
        return soma / array.Length;
    }

    static void Main()
    {
        int n;
        double media;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        media = mediaValoresVetor(vetor);
        Console.WriteLine($"\nMédia dos valores do vetor: {media:F2}");
    }
}