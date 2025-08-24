using System;
using MinhaBiblioteca;

class Atividade2
{
    static int qtdImpares(int[] array)
    {
        int qtdImpares = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
                qtdImpares++;
        }
        return qtdImpares;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        Console.WriteLine($"\nQuantidade de números ímpares no vetor: {qtdImpares(vetor)}");
    }
}