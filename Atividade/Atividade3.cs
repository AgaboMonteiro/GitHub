using System;
using MinhaBiblioteca;

class Atividade3
{
    static int menorElemento(int[] array)
    {
        int menorElemento = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menorElemento)
                menorElemento = array[i];
        }
        return menorElemento;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        Console.WriteLine(value: $"\nMenor elemento do vetor: {menorElemento(vetor)}");
    }
}